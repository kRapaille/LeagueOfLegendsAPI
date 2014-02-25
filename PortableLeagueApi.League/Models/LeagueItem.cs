using System;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.League.Models.DTO;

namespace PortableLeagueApi.League.Models
{
    public class LeagueItem : ApiModel, ILeagueItem
    {
        public bool IsFreshBlood { get; set; }
        public bool IsHotStreak { get; set; }
        public bool IsInactive { get; set; }
        public bool IsVeteran { get; set; }
        public DateTime LastPlayed { get; set; }
        public string LeagueName { get; set; }
        public int LeaguePoints { get; set; }
        public IMiniSeries MiniSeries { get; set; }
        public string PlayerOrTeamId { get; set; }
        public string PlayerOrTeamName { get; set; }
        public string QueueType { get; set; }
        public string Rank { get; set; }
        public string Tier { get; set; }
        public int Wins { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.MiniSeries.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<LeagueItemDto, ILeagueItem>().As<LeagueItem>();
            autoMapperService.CreateApiModelMap<LeagueItemDto, LeagueItem>();
        }
    }
}
