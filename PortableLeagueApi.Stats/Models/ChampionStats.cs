using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Stats.Models.DTO;

namespace PortableLeagueApi.Stats.Models
{
    public class ChampionStats : ApiModel, IChampionStats
    {
        public int ChampionId { get; set; }
        public IAggregatedStats Stats { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            AggregatedStats.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<ChampionStatsDto, IChampionStats>().As<ChampionStats>();
            autoMapperService.CreateApiModelMap<ChampionStatsDto, ChampionStats>();
        }
    }
}