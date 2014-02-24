using PortableLeagueAPI.Champion.Services;
using PortableLeagueApi.Game.Services;
using PortableLeagueApi.Interfaces.Champion;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.League.Services;
using PortableLeagueAPI.Services;
using PortableLeagueApi.Static.Services;
using PortableLeagueApi.Stats.Services;
using PortableLeagueApi.Summoner.Services;
using PortableLeagueApi.Team.Services;

namespace PortableLeagueAPI
{
    public class LeagueAPI : ILeagueAPI
    {
        public IChampionService Champion { get; private set; }
        public IGameService Game { get; private set; }
        public ILeagueService League { get; private set; }
        public IStatsService Stats { get; private set; }
        public ISummonerService Summoner { get; private set; }
        public ITeamService Team { get; private set; }
        public StaticService Static { get; private set; }

        public string Key { get; private set; }
        public RegionEnum? DefaultRegion { get; private set; }
        public bool WaitToAvoidRateLimit { get; private set; }
        public IHttpRequestService HttpRequestService { get; private set; }
        
        public LeagueAPI(
            string key,
            RegionEnum? region = null,
            bool waitToAvoidRateLimit = false,
            IHttpRequestService httpRequestService = null)
        {
            httpRequestService = httpRequestService ?? new HttpRequestService();

            Key = key;
            DefaultRegion = region;
            WaitToAvoidRateLimit = waitToAvoidRateLimit;
            HttpRequestService = httpRequestService;

            Champion = new ChampionService(this);
            Game = new GameService(this);
            League = new LeagueService(this);
            Stats = new StatsService(this);
            Summoner = new SummonerService(this);
            Team = new TeamService(this);
            Static = new StaticService(this);
        }
    }
}