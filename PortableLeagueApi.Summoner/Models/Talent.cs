using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class Talent : LeagueApiModel, ITalent
    {
        public int Id { get; set; }

        public int Rank { get; set; }

        public string Name { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            autoMapperService.CreateMap<TalentDto, ITalent>().As<Talent>();
            autoMapperService.CreateMap<TalentDto, Talent>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}