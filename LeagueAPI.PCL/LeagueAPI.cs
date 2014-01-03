﻿using LeagueAPI.PCL.Interfaces;
using LeagueAPI.PCL.Models.Enums;
using LeagueAPI.PCL.Models.IoC;
using LeagueAPI.PCL.Services;

namespace LeagueAPI.PCL
{
    public static class LeagueAPI
    {
        public static ChampionService Champion { get; private set; }
        public static GameService Game { get; private set; }
        public static LeagueService League { get; private set; }
        public static StatsService Stats { get; private set; }
        public static SummonerService Summoner { get; private set; }
        public static TeamService Team { get; private set; }
        
        public static void Init(
            string key,
            IResolver resolver = null)
        {
            IoC.Initialize(resolver ?? new AutoFacResolver());

            BaseService.HttpRequestService = IoC.Resolve<IHttpRequestService>();
            BaseService.Key = key;

            Champion = ChampionService.Instance;
            Game = GameService.Instance;
            League = LeagueService.Instance;
            Stats = StatsService.Instance;
            Summoner = SummonerService.Instance;
            Team = TeamService.Instance;
        }

        public static void SetDefaultRegion(RegionEnum regionEnum)
        {
            BaseService.DefaultRegion = regionEnum;
        }
    }
}