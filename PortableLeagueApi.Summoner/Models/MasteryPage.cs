using System.Collections.Generic;
using System.Linq;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
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

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            Talent.CreateMap(autoMapperService, source);

            autoMapperService.CreateMap<MasteryPageDto, IMasteryPage>().As<MasteryPage>();
            autoMapperService.CreateMap<MasteryPageDto, MasteryPage>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });

            autoMapperService.CreateMap<MasteryPagesDto, IEnumerable<IMasteryPage>>()
                .ConvertUsing(x => x.Pages.Select(autoMapperService.Map<MasteryPageDto, IMasteryPage>));
        }
    }
}
