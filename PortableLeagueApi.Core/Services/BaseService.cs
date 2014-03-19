using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Helpers;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Services
{
    public abstract class BaseService : IDisposable
    {
        private static readonly Uri BaseUri = new Uri("http://prod.api.pvp.net/api/lol/");

        private static readonly Dictionary<string, List<DateTime>> LastRequests =
            new Dictionary<string, List<DateTime>>();

        private readonly ILeagueApiConfiguration _apiConfiguration;

        private readonly bool _isLimitedByRateLimit;
        private VersionEnum? _version;

        private const int MaxRequestsPer10Sec = 10;
        private const int MaxRequestsPer10Min = 500;

        protected AutoMapperService AutoMapperService { get; private set; }

        protected string Prefix { get; private set; }

        protected string VersionText
        {
            get
            {
                return _version.HasValue ? VersionConsts.Versions[_version.Value] : string.Empty;
            }
        }

        protected BaseService(
            ILeagueApiConfiguration apiConfiguration,
            VersionEnum version,
            string prefix,
            bool isLimitedByRateLimit = true)
        {
            if (apiConfiguration == null) throw new ArgumentNullException("apiConfiguration");
            if (prefix == null) throw new ArgumentNullException("prefix");

            _apiConfiguration = apiConfiguration;

            _version = version;
            Prefix = prefix;
            _isLimitedByRateLimit = isLimitedByRateLimit;

            if (!LastRequests.ContainsKey(_apiConfiguration.Key))
                LastRequests[_apiConfiguration.Key] = new List<DateTime>();

            AutoMapperService = new AutoMapperService(apiConfiguration);

            AutoMapperService.CreateMap<long, DateTime>()
                .ConvertUsing(x => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(x));
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

            var keyParameter = string.Format("api_key={0}", _apiConfiguration.Key);
            uriBuilder.AddQueryParameter(keyParameter);

            return uriBuilder.Uri;
        }

        protected async Task<TDestination> GetResponseAsync<TSource, TDestination>(RegionEnum? region,
            string relativeUrl)
            where TSource : class
        {
            var result = await GetResponseAsync<TSource>(BuildUri(region, relativeUrl));

            return AutoMapperService.Map<TSource, TDestination>(result);
        }

        protected async Task<TDestination> GetResponseAsync<TSource, TDestination>(Uri uri)
            where TSource : class
        {
            var result = await GetResponseAsync<TSource>(uri);

            return AutoMapperService.Map<TSource, TDestination>(result);
        }

        protected async Task<T> GetResponseAsync<T>(RegionEnum? region, string relativeUrl) where T : class
        {
            return await GetResponseAsync<T>(BuildUri(region, relativeUrl));
        }

        protected virtual async Task<T> GetResponseAsync<T>(Uri uri) where T : class
        {
            await ManageRateLimit();

            var response = await _apiConfiguration.HttpRequestService.SendRequestAsync(uri);

            T result;

            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<T>(content, new JsonSerializerSettings
                                                                   {
#if DEBUG
                                                                       MissingMemberHandling =
                                                                           MissingMemberHandling.Error
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

            if (_apiConfiguration.WaitToAvoidRateLimit && _isLimitedByRateLimit)
            {
                LastRequests[_apiConfiguration.Key].Add(DateTime.Now);

                var tenMinutesAgo = DateTime.Now.AddMinutes(-10);
                LastRequests[_apiConfiguration.Key].RemoveAll(x => x < tenMinutesAgo);

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

            var requestsInGivenTime = LastRequests[_apiConfiguration.Key]
                .Where(x => x >= givenTimeAgo)
                .OrderBy(x => x)
                .ToList();

            var delay = 0;

            if (requestsInGivenTime.Count() >= maxRequestsInGivenTime)
            {
                var first = requestsInGivenTime.FirstOrDefault();
                var limitReleaseDateTime = first.AddSeconds(givenTimeInSeconds);

                delay = (int) limitReleaseDateTime.Subtract(DateTime.Now).TotalMilliseconds;

                if (delay < 0)
                    delay = 0;
            }

            return delay > currentDelay ? delay : currentDelay;
        }

        protected RegionEnum GetRegion(RegionEnum? region)
        {
            region = region.HasValue ? region : _apiConfiguration.DefaultRegion;

            if (region == null)
                throw new ArgumentException("There's no default region");

            return region.Value;
        }

        protected string GetRegionAsString(RegionEnum? region)
        {
            return RegionConsts.Regions[GetRegion(region)];
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool canCleanUpManagedandNativeRessources)
        {
            if (canCleanUpManagedandNativeRessources)
            {
                if (AutoMapperService != null)
                {
                    AutoMapperService.Dispose();
                    AutoMapperService = null;
                }
            }
        }
    }
}
