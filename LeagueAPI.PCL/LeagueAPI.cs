using PortableLeagueAPI.Champion.Services;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Game.Services;
using PortableLeagueApi.League.Services;
using PortableLeagueAPI.Services;
using PortableLeagueApi.Static.Services;
using PortableLeagueApi.Stats.Services;
using PortableLeagueApi.Summoner.Services;
using PortableLeagueApi.Team.Services;

namespace PortableLeagueAPI
{
    public class LeagueAPI
    {
        public ChampionService Champion { get; private set; }
        public GameService Game { get; private set; }
        public LeagueService League { get; private set; }
        public StatsService Stats { get; private set; }
        public SummonerService Summoner { get; private set; }
        public TeamService Team { get; private set; }
        public StaticService Static { get; private set; }

        public LeagueAPI(
            string key,
            RegionEnum? region = null,
            bool waitToAvoidRateLimit = false,
            IHttpRequestService httpRequestService = null)
        {
            httpRequestService = httpRequestService ?? new HttpRequestService();

            Champion = new ChampionService(key, httpRequestService, region, waitToAvoidRateLimit);
            Game = new GameService(key, httpRequestService, region, waitToAvoidRateLimit);
            League = new LeagueService(key, httpRequestService, region, waitToAvoidRateLimit);
            Stats = new StatsService(key, httpRequestService, region, waitToAvoidRateLimit);
            Summoner = new SummonerService(key, httpRequestService, region, waitToAvoidRateLimit);
            Team = new TeamService(key, httpRequestService, region, waitToAvoidRateLimit);
            Static = new StaticService(key, httpRequestService, region, waitToAvoidRateLimit);
        }
    }
}