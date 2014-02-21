using PortableLeagueApi.Interfaces.Champion;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.Interfaces.Stats;

namespace PortableLeagueApi.Interfaces.Core
{
    public interface ILeagueAPI
    {
        IChampionService Champion { get; }
        IGameService Game { get; }
        ILeagueService League { get; }
        IStatsService Stats { get; }

        string Key { get; }
        RegionEnum? DefaultRegion { get; }
        bool WaitToAvoidRateLimit { get; }
        IHttpRequestService HttpRequestService { get; }
    }
}