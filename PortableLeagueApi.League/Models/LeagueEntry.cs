using System;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.League.Models.DTO;

namespace PortableLeagueApi.League.Models
{
    public class LeagueEntry : ApiModel, ILeagueEntry
    {
        public string Division { get; set; }
        public bool IsFreshBlood { get; set; }
        public bool IsHotStreak { get; set; }
        public bool IsInactive { get; set; }
        public bool IsVeteran { get; set; }
        public int LeaguePoints { get; set; }
        public IMiniSeries MiniSeries { get; set; }
        public string PlayerOrTeamId { get; set; }
        public string PlayerOrTeamName { get; set; }
        public int Wins { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.MiniSeries.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<LeagueEntryDto, ILeagueEntry>().As<LeagueEntry>();
            autoMapperService.CreateApiModelMap<LeagueEntryDto, LeagueEntry>();
        }
    }
}
