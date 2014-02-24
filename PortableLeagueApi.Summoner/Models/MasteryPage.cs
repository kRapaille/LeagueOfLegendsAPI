using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{

    public class MasteryPage : LeagueApiModel, IMasteryPage
    {
        public long Id { get; set; }

        public ITalent[] Talents { get; set; }

        public string Name { get; set; }

        public bool Current { get; set; }

        internal static void CreateMap(ILeagueAPI source)
        {
            Talent.CreateMap(source);

            Mapper.CreateMap<MasteryPageDto, IMasteryPage>().As<MasteryPage>();
            Mapper.CreateMap<MasteryPageDto, MasteryPage>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });

            Mapper.CreateMap<MasteryPagesDto, IEnumerable<IMasteryPage>>()
                .ConvertUsing(x => x.Pages.Select(Mapper.Map<MasteryPageDto, IMasteryPage>));
        }
    }
}
