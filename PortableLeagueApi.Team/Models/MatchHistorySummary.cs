using System;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
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

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            autoMapperService.CreateMap<MatchHistorySummaryDto, IMatchHistorySummary>().As<MatchHistorySummary>();
            autoMapperService.CreateMap<MatchHistorySummaryDto, MatchHistorySummary>()
                .BeforeMap((s, d) =>
                           {
                               d.Map = (MapEnum)s.MapId;

                               d.Source = source;
                           });
        }
    }
}