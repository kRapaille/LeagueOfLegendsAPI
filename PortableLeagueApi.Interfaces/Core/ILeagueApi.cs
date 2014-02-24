using PortableLeagueApi.Interfaces.Champion;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Interfaces.Team;

namespace PortableLeagueApi.Interfaces.Core
{
    public interface ILeagueAPI
    {
        IChampionService Champion { get; }
        IGameService Game { get; }
        ILeagueService League { get; }
        IStatsService Stats { get; }
        ISummonerService Summoner { get; }
        ITeamService Team { get; }

        string Key { get; }
        RegionEnum? DefaultRegion { get; }
        bool WaitToAvoidRateLimit { get; }
        IHttpRequestService HttpRequestService { get; }
    }
}