using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class Talent : ApiModel, ITalent
    {
        public int Id { get; set; }

        public int Rank { get; set; }

        public string Name { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<TalentDto, ITalent>().As<Talent>();
            autoMapperService.CreateApiModelMap<TalentDto, Talent>();
        }
    }
}