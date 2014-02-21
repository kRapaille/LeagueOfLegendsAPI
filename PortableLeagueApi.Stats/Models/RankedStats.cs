using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Stats.Models.DTO;

namespace PortableLeagueApi.Stats.Models
{
    public class RankedStats : LeagueApiModel, IRankedStats
    {
        public long ModifyDate { get; set; }
        public IChampionStats[] Champions { get; set; }
        public long SummonerId { get; set; }

        public static void CreateMap(ILeagueAPI source)
        {
            ChampionStats.CreateMap(source);

            Mapper.CreateMap<RankedStatsDto, IRankedStats>().As<RankedStats>();
            Mapper.CreateMap<RankedStatsDto, RankedStats>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });
        }
    }
}
