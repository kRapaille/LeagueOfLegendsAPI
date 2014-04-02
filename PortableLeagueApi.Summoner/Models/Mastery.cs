using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class Mastery : ApiModel, IMastery
    {
        public int Id { get; set; }

        public int Rank { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<MasteryDto, IMastery>().As<Mastery>();
            autoMapperService.CreateApiModelMap<MasteryDto, Mastery>();
        }
    }
}