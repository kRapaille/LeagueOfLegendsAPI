using System.Collections.Generic;
using System.Linq;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class RunePage : LeagueApiModel, IRunePage
    {
        public int Id { get; set; }

        public IRuneSlot[] Slots { get; set; }

        public string Name { get; set; }

        public bool Current { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            RuneSlot.CreateMap(autoMapperService, source);

            autoMapperService.CreateMap<RunePageDto, IRunePage>().As<RunePage>();
            autoMapperService.CreateMap<RunePageDto, RunePage>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });

            autoMapperService.CreateMap<RunePagesDto, IEnumerable<IRunePage>>()
                .ConvertUsing(x => x.Pages.Select(autoMapperService.Map<RunePageDto, IRunePage>));
        }
    }
}
