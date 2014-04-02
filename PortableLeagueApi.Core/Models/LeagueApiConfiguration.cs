using System;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Models
{
    public class LeagueApiConfiguration : ILeagueApiConfiguration
    {
        public LeagueApiConfiguration(
            string key, 
            RegionEnum? defaultRegion, 
            bool waitToAvoidRateLimit, 
            IHttpRequestService httpRequestService = null)
        {
            if (key == null) throw new ArgumentNullException("key");
            if (httpRequestService == null) throw new ArgumentNullException("httpRequestService");

            Key = key;
            DefaultRegion = defaultRegion;
            WaitToAvoidRateLimit = waitToAvoidRateLimit;
            HttpRequestService = httpRequestService;
        }

        public string Key { get; set; }
        public RegionEnum? DefaultRegion { get; set; }
        public bool WaitToAvoidRateLimit { get; set; }
        public IHttpRequestService HttpRequestService { get; set; }
    }
}