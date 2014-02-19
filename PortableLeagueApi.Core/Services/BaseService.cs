using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Helpers;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Models;

namespace PortableLeagueApi.Core.Services
{
    public abstract class BaseService
    {
        private static readonly Uri BaseUri = new Uri("http://prod.api.pvp.net/api/lol/");
        private static readonly Dictionary<string, List<DateTime>> LastRequests = new Dictionary<string, List<DateTime>>();

        private readonly IHttpRequestService _httpRequestService;
        private readonly string _key;
        private readonly RegionEnum? _defaultRegion;
        private readonly bool _waitToAvoidRateLimit;
        private readonly bool _isLimitedByRateLimit;
        private VersionEnum? _version;

        private const int MaxRequestsPer10Sec = 10;
        private const int MaxRequestsPer10Min = 500;
        
        protected string Prefix { get; private set; }

        protected string VersionText
        {
            get {
                return _version.HasValue ? VersionConsts.Versions[_version.Value] : string.Empty;
            }
        }

        protected BaseService(
            string key,
            IHttpRequestService httpRequestService,
            VersionEnum? version, 
            string prefix,
            RegionEnum? defaultRegion,
            bool waitToAvoidRateLimit,
            bool isLimitedByRateLimit = true)
        {
            _key = key;
            _httpRequestService = httpRequestService;
            _version = version;
            Prefix = prefix;
            _defaultRegion = defaultRegion;
            _waitToAvoidRateLimit = waitToAvoidRateLimit;
            _isLimitedByRateLimit = isLimitedByRateLimit;

            if(!LastRequests.ContainsKey(_key))
                LastRequests[_key] = new List<DateTime>();
        }

        protected virtual Uri BuildUri(RegionEnum? region, string relativeUrl)
        {
            relativeUrl = string.Format("{0}/{1}/{2}/{3}",
                   GetRegionAsString(region),
                   VersionText,
                   Prefix,
                   relativeUrl);

            return BuildUri(new Uri(relativeUrl, UriKind.Relative));
        }

        protected Uri BuildUri(Uri relativeUri)
        {
            var uriBuilder = new UriBuilder(new Uri(BaseUri, relativeUri));

            var keyParameter = string.Format("api_key={0}", _key);
            uriBuilder.AddQueryParameter(keyParameter);

            return uriBuilder.Uri;
        }

        protected async Task<T> GetResponseAsync<T>(RegionEnum? region, string relativeUrl) where T : class
        {
            return await GetResponseAsync<T>(BuildUri(region, relativeUrl));
        }

        protected virtual async Task<T> GetResponseAsync<T>(Uri uri) where T : class
        {
            await ManageRateLimit();

            var response = await _httpRequestService.SendRequestAsync(uri);

            T result;

            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<T>(content, new JsonSerializerSettings
                {
#if DEBUG
                    MissingMemberHandling = MissingMemberHandling.Error
#endif
                });
            }
            else
            {
                var url = uri.ToString();

                Debug.WriteLine(url);

                APIRequestError apiRequestError;

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    apiRequestError = new APIRequestError
                    {
                        Status = new APIRequestErrorStatus
                        {
                            Message = "Not found",
                            StatusCode = 404
                        }
                    };
                }
                else
                {
                    apiRequestError = JsonConvert.DeserializeObject<APIRequestError>(content);
                }

                throw new APIRequestException(apiRequestError, url);
            }

            return result;
        }

        private Task ManageRateLimit()
        {
            var delayInMs = 0;

            if (_waitToAvoidRateLimit && _isLimitedByRateLimit)
            {
                LastRequests[_key].Add(DateTime.Now);

                var tenMinutesAgo = DateTime.Now.AddMinutes(-10);
                LastRequests[_key].RemoveAll(x => x < tenMinutesAgo);
                
                delayInMs = CalculateDelay(MaxRequestsPer10Min, 600, delayInMs);
                delayInMs = CalculateDelay(MaxRequestsPer10Sec, 10, delayInMs);

                // Add 1s to be sure
                if (delayInMs > 0)
                    delayInMs += 1000;
                
                Debug.WriteLine(delayInMs);
            }
            
            return Task.Delay(delayInMs);
        }

        private int CalculateDelay(int maxRequestsInGivenTime, int givenTimeInSeconds, int currentDelay)
        {
            var givenTimeAgo = DateTime.Now.AddSeconds(-(givenTimeInSeconds + 1));

            var requestsInGivenTime = LastRequests[_key]
                .Where(x => x >= givenTimeAgo)
                .OrderBy(x => x)
                .ToList();

            var delay = 0;

            if (requestsInGivenTime.Count() >= maxRequestsInGivenTime)
            {
                var first = requestsInGivenTime.FirstOrDefault();
                var limitReleaseDateTime = first.AddSeconds(givenTimeInSeconds);

                delay = (int)limitReleaseDateTime.Subtract(DateTime.Now).TotalMilliseconds;

                if (delay < 0)
                    delay = 0;
            }

            return delay > currentDelay ? delay : currentDelay;
        }

        protected RegionEnum GetRegion(RegionEnum? region)
        {
            region = region.HasValue ? region : _defaultRegion;

            if (region == null)
                throw new ArgumentException("There's no default region");

            return region.Value;
        }
        
        protected string GetRegionAsString(RegionEnum? region)
        {
            return _version.HasValue ? VersionConsts.Versions[_version.Value] : string.Empty;
        }
    }
}
