using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
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

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            AggregatedStats.CreateMap(autoMapperService, source);

            autoMapperService.CreateMap<ChampionStatsDto, IChampionStats>().As<ChampionStats>();
            autoMapperService.CreateMap<ChampionStatsDto, ChampionStats>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });
        }
    }
}