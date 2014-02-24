using System;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Stats.Models.DTO;

namespace PortableLeagueApi.Stats.Models
{
    public class RankedStats : LeagueApiModel, IRankedStats
    {
        public DateTime ModifyDate { get; set; }
        public IChampionStats[] Champions { get; set; }
        public long SummonerId { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            ChampionStats.CreateMap(autoMapperService, source);

            autoMapperService.CreateMap<RankedStatsDto, IRankedStats>().As<RankedStats>();
            autoMapperService.CreateMap<RankedStatsDto, RankedStats>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });
        }
    }
}
