using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class RuneSlot : ApiModel, IRuneSlot
    {
        public int RuneSlotId { get; set; }

        public int RuneId { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<RuneSlotDto, IRuneSlot>().As<RuneSlot>();
            autoMapperService.CreateApiModelMap<RuneSlotDto, RuneSlot>();
        }
    }
}