using PortableLeagueAPI.Champion.Services;
using PortableLeagueApi.Core.Models;
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
    public class LeagueApi
    {
        public IChampionService Champion { get; private set; }
        public IGameService Game { get; private set; }
        public ILeagueService League { get; private set; }
        public IStatsService Stats { get; private set; }
        public ISummonerService Summoner { get; private set; }
        public ITeamService Team { get; private set; }
        public StaticService Static { get; private set; }

        public LeagueApi(
            string key,
            RegionEnum? region = null,
            bool waitToAvoidRateLimit = false,
            IHttpRequestService httpRequestService = null)
        {
            httpRequestService = httpRequestService ?? new HttpRequestService();

            var leagueApiConfiguration = new LeagueApiConfiguration(key, region, waitToAvoidRateLimit, httpRequestService);

            Champion = new ChampionService(leagueApiConfiguration);
            Game = new GameService(leagueApiConfiguration);
            League = new LeagueService(leagueApiConfiguration);
            Stats = new StatsService(leagueApiConfiguration);
            Summoner = new SummonerService(leagueApiConfiguration);
            Team = new TeamService(leagueApiConfiguration);
            Static = new StaticService(leagueApiConfiguration);
        }
    }
}