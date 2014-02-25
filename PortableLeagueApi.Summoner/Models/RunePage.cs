using System.Collections.Generic;
using System.Linq;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
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

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            RuneSlot.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<RunePageDto, IRunePage>().As<RunePage>();
            autoMapperService.CreateApiModelMap<RunePageDto, RunePage>();

            autoMapperService.CreateMap<RunePagesDto, IEnumerable<IRunePage>>()
                .ConvertUsing(x => x.Pages.Select(autoMapperService.Map<RunePageDto, IRunePage>));
        }
    }
}
