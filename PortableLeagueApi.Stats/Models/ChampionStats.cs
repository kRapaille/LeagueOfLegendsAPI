using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Stats.Models.DTO;

namespace PortableLeagueApi.Stats.Models
{
    public class ChampionStats : LeagueApiModel, IChampionStats
    {
        public int ChampionId { get; set; }
        public IAggregatedStats Stats { get; set; }
        public string Name { get; set; }

        public static void CreateMap(ILeagueAPI source)
        {
            AggregatedStats.CreateMap(source);

            Mapper.CreateMap<ChampionStatsDto, IChampionStats>().As<ChampionStats>();
            Mapper.CreateMap<ChampionStatsDto, ChampionStats>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });
        }
    }
}