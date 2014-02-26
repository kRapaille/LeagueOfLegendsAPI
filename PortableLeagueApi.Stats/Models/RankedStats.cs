using System;
using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Stats.Models.DTO;

namespace PortableLeagueApi.Stats.Models
{
    public class RankedStats : ApiModel, IRankedStats
    {
        public DateTime ModifyDate { get; set; }
        public IList<IChampionStats> Champions { get; set; }
        public long SummonerId { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            ChampionStats.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<RankedStatsDto, IRankedStats>().As<RankedStats>();
            autoMapperService.CreateApiModelMap<RankedStatsDto, RankedStats>();
        }
    }
}
