using AutoMapper;
using PortableLeagueApi.Core.Models;
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

        internal static void CreateMap(ILeagueAPI source)
        {
            Mapper.CreateMap<TalentDto, ITalent>().As<Talent>();
            Mapper.CreateMap<TalentDto, Talent>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}