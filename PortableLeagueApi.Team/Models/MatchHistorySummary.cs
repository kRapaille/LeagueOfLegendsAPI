using System;
using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class MatchHistorySummary : LeagueApiModel, IMatchHistorySummary
    {
        public int Assists { get; set; }

        public DateTime Date { get; set; }

        public int Deaths { get; set; }

        public int GameId { get; set; }

        public string GameMode { get; set; }

        public bool Invalid { get; set; }

        public int Kills { get; set; }

        public MapEnum Map { get; set; }

        public int OpposingTeamKills { get; set; }

        public string OpposingTeamName { get; set; }

        public bool Win { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            CreateMap<MatchHistorySummary>(autoMapperService);
            CreateMap<IMatchHistorySummary>(autoMapperService).As<MatchHistorySummary>();
        }

        private static IMappingExpression<MatchHistorySummaryDto, T> CreateMap<T>(AutoMapperService autoMapperService)
            where T : IMatchHistorySummary
        {
            return autoMapperService.CreateApiModelMap<MatchHistorySummaryDto, T>()
                .ForMember(x => x.Map, x => x.Ignore())
                .AfterMap((s, d) =>
                {
                    d.Map = (MapEnum)s.MapId;
                });
        }
    }
}