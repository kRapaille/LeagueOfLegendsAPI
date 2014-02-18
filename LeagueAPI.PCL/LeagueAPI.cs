using System;
using PortableLeagueAPI.Champion.Services;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Models.IoC;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Game.Services;
using PortableLeagueApi.League.Services;
using PortableLeagueAPI.Models.IoC;
using PortableLeagueApi.Static.Services;
using PortableLeagueApi.Stats.Services;
using PortableLeagueApi.Summoner.Services;
using PortableLeagueApi.Team.Services;

namespace PortableLeagueAPI
{
    public static class LeagueAPI
    {
        public static ChampionService Champion { get; private set; }
        public static GameService Game { get; private set; }
        public static LeagueService League { get; private set; }
        public static StatsService Stats { get; private set; }
        public static SummonerService Summoner { get; private set; }
        public static TeamService Team { get; private set; }
        public static StaticService Static { get; private set; }

        public static bool WaitToAvoidRateLimit
        {
            set { BaseService.WaitToAvoidRateLimit = value; }
        }

        public static RegionEnum? DefaultRegion
        {
            set { BaseService.DefaultRegion = value; }
        }
        
        public static void Init(
            string key,
            IResolver resolver = null)
        {
            BaseService.Key = key;

            IoC.Initialize(resolver ?? new LeagueResolver());
            var httpRequestService = IoC.Resolve<IHttpRequestService>();
            if(httpRequestService == null)
                throw new NullReferenceException("IHttpRequestService cannot be resolve.");

            BaseService.HttpRequestService = httpRequestService;

            WaitToAvoidRateLimit = false;

            Champion = ChampionService.Instance;
            Game = GameService.Instance;
            League = LeagueService.Instance;
            Stats = StatsService.Instance;
            Summoner = SummonerService.Instance;
            Team = TeamService.Instance;
            Static = StaticService.Instance;
        }
    }
}