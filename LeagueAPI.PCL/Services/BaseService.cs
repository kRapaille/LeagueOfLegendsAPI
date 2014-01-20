using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PortableLeagueAPI.Helpers;
using PortableLeagueAPI.Interfaces;
using PortableLeagueAPI.Models.Constants;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Exceptions;

namespace PortableLeagueAPI.Services
{
    public abstract class BaseService
    {
        private static readonly Uri BaseUri = new Uri("http://prod.api.pvp.net/api/lol/");
        private static readonly List<DateTime> LastRequests = new List<DateTime>();

        private const int MaxRequestsPer10Sec = 10;
        private const int MaxRequestsPer10Min = 500;
        
        internal static IHttpRequestService HttpRequestService { private get; set; }
        internal static string Key { private get; set; }
        internal static RegionEnum? DefaultRegion { private get; set; }
        internal static bool WaitToAvoidRateLimit { get; set; }

        protected bool IsLimitedByRateLimit { get; set; }
        protected VersionEnum? Version { get; set; }

        protected string VersionText
        {
            get
            {
                return Version.HasValue ? VersionConsts.Versions[Version.Value] : string.Empty;
            }
        }

        protected BaseService(VersionEnum? version)
        {
            Version = version;
            IsLimitedByRateLimit = true;
        }
        
        protected BaseService(bool isLimitedByRateLimit)
        {
            IsLimitedByRateLimit = isLimitedByRateLimit;
        }

        protected async Task<T> GetResponse<T>(RegionEnum? region, string relativeUrl) where T : class
        {
            relativeUrl = string.Format("{0}/{1}/{2}", 
                GetRegionAsString(region),
                VersionText,
                relativeUrl);

            return await GetResponse<T>(new Uri(relativeUrl, UriKind.Relative));
        }

        protected async Task<T> GetResponse<T>(Uri relativeUri) where T : class
        {
            var uriBuilder = new UriBuilder(new Uri(BaseUri, relativeUri));

            var keyParameter = string.Format("api_key={0}", Key);
            uriBuilder.AddQueryParameter(keyParameter);

            await ManageRateLimit();

            var response = await HttpRequestService.SendRequest<T>(uriBuilder.Uri);

            T result;

            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<T>(content, new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Error
                });
            }
            else
            {
                var url = uriBuilder.Uri.ToString();

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

            if (WaitToAvoidRateLimit && IsLimitedByRateLimit)
            {
                LastRequests.Add(DateTime.Now);

                var tenMinutesAgo = DateTime.Now.AddMinutes(-10);
                LastRequests.RemoveAll(x => x < tenMinutesAgo);
                
                delayInMs = CalculateDelay(MaxRequestsPer10Min, 600, delayInMs);
                delayInMs = CalculateDelay(MaxRequestsPer10Sec, 10, delayInMs);

                // Add 1s to be sure
                if (delayInMs > 0)
                    delayInMs += 1000;
            }

            return Task.Delay(delayInMs);
        }

        private static int CalculateDelay(int maxRequestsInGivenTime, int givenTimeInSeconds, int currentDelay)
        {
            var givenTimeAgo = DateTime.Now.AddSeconds(-givenTimeInSeconds);

            var requestsInGivenTime = LastRequests.Where(x => x >= givenTimeAgo).ToList();

            var delay = 0;

            if (requestsInGivenTime.Count() > maxRequestsInGivenTime)
            {
                var first = requestsInGivenTime.FirstOrDefault();
                var limitReleaseDateTime = first.AddSeconds(givenTimeInSeconds);

                delay = (int)limitReleaseDateTime.Subtract(DateTime.Now).TotalMilliseconds;

                Debug.WriteLine(delay);
            }

            return delay > currentDelay ? delay : currentDelay;
        }

        protected RegionEnum GetRegion(RegionEnum? region)
        {
            region = region.HasValue ? region : DefaultRegion;

            if (region == null)
                throw new ArgumentException("There's no default region");

            return region.Value;
        }
        
        protected string GetRegionAsString(RegionEnum? region)
        {
            return GetRegion(region).ToString().ToLower();
        }
    }
}
