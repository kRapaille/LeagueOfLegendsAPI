using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class Rune : ApiModel, IRune
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public int Tier { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<RuneDto, IRune>().As<Rune>();
            autoMapperService.CreateApiModelMap<RuneDto, Rune>();
        }
    }
}