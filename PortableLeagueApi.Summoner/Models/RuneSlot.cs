using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class RuneSlot : LeagueApiModel, IRuneSlot
    {
        public int RuneSlotId { get; set; }

        public IRune Rune { get; set; }

        internal static void CreateMap(ILeagueAPI source)
        {
            Models.Rune.CreateMap(source);
            
            Mapper.CreateMap<RuneSlotDto, IRuneSlot>().As<RuneSlot>();
            Mapper.CreateMap<RuneSlotDto, RuneSlot>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}