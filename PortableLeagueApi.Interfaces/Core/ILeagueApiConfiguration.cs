using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Core
{
    public interface ILeagueApiConfiguration
    {
        string Key { get; set; }
        RegionEnum? DefaultRegion { get; set; }
        bool WaitToAvoidRateLimit { get; set; }
        IHttpRequestService HttpRequestService { get; set; }
    }
}