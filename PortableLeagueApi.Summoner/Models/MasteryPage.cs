using System.Collections.Generic;
using System.Linq;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class MasteryPage : ApiModel, IMasteryPage
    {
        public long Id { get; set; }

        public IList<ITalent>Talents { get; set; }

        public string Name { get; set; }

        public bool Current { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Talent.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<MasteryPageDto, IMasteryPage>().As<MasteryPage>();
            autoMapperService.CreateApiModelMap<MasteryPageDto, MasteryPage>();

            autoMapperService.CreateMap<MasteryPagesDto, IEnumerable<IMasteryPage>>()
                .ConvertUsing(x => x.Pages.Select(autoMapperService.Map<MasteryPageDto, IMasteryPage>));
        }
    }
}
