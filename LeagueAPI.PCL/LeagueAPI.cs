using System;
using PortableLeagueAPI.Champion.Services;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Game.Services;
using PortableLeagueApi.Interfaces.Champion;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.Interfaces.Static;
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
        public IStaticService Static { get; private set; }

        public ILeagueApiConfiguration LeagueApiConfiguration { get; private set; }

        public LeagueApi(ILeagueApiConfiguration leagueApiConfiguration)
        {
            if (leagueApiConfiguration == null) throw new ArgumentNullException("leagueApiConfiguration");

            LeagueApiConfiguration = leagueApiConfiguration;

            Init();
        }

        public LeagueApi(
            string apiKey,
            RegionEnum? region = null,
            bool waitToAvoidRateLimit = false,
            IHttpRequestService httpRequestService = null)
        {
            if(apiKey == null) throw new ArgumentNullException("apiKey");

            httpRequestService = httpRequestService ?? new HttpRequestService();

            LeagueApiConfiguration = new LeagueApiConfiguration(apiKey, region, waitToAvoidRateLimit, httpRequestService);

            Init();
        }

        private void Init()
        {
            Champion = new ChampionService(LeagueApiConfiguration);
            Game = new GameService(LeagueApiConfiguration);
            League = new LeagueService(LeagueApiConfiguration);
            Stats = new StatsService(LeagueApiConfiguration);
            Summoner = new SummonerService(LeagueApiConfiguration);
            Team = new TeamService(LeagueApiConfiguration);
            Static = new StaticService(LeagueApiConfiguration);
        }
    }
}