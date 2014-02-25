using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class RuneSlot : LeagueApiModel, IRuneSlot
    {
        public int RuneSlotId { get; set; }

        public IRune Rune { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.Rune.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<RuneSlotDto, IRuneSlot>().As<RuneSlot>();
            autoMapperService.CreateApiModelMap<RuneSlotDto, RuneSlot>();
        }
    }
}