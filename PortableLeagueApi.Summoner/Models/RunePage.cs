using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PortableLeagueApi.Core.Models;
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

        internal static void CreateMap(ILeagueAPI source)
        {
            RuneSlot.CreateMap(source);

            Mapper.CreateMap<RunePageDto, IRunePage>().As<RunePage>();
            Mapper.CreateMap<RunePageDto, RunePage>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
            
            Mapper.CreateMap<RunePagesDto, IEnumerable<IRunePage>>()
                .ConvertUsing(x => x.Pages.Select(Mapper.Map<RunePageDto, IRunePage>));
        }
    }
}
