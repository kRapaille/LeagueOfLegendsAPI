using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Rune;
using PortableLeagueApi.Static.Models.DTO.Rune;

namespace PortableLeagueApi.Static.Models.Rune
{
    public class RuneType : ApiModel, IRuneType
    {
        public bool Isrune { get; set; }

        public string Tier { get; set; }

        public string Type { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<RuneTypeDto, RuneType, IRuneType>();
        }
    }
}
