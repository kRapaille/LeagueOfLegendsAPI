using PortableLeagueApi.Interfaces.Champion;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.League;

namespace PortableLeagueApi.Interfaces.Core
{
    public interface ILeagueAPI
    {
        IChampionService Champion { get; }
        IGameService Game { get; }
        ILeagueService League { get; }

        string Key { get; }
        RegionEnum? DefaultRegion { get; }
        bool WaitToAvoidRateLimit { get; }
        IHttpRequestService HttpRequestService { get; }
    }
}