using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Rune;
using PortableLeagueApi.Static.Models.DTO.Rune;

namespace PortableLeagueApi.Static.Models.Rune
{
    public class RuneList : ApiModel, IRuneList
    {
        public IBasicData Basic { get; set; }

        public IDictionary<string, IRune> Data { get; set; }

        public string Type { get; set; }

        public string Version { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            BasicData.CreateMap(autoMapperService);
            Rune.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<RuneListDto, RuneList, IRuneList>();
        }
    }
}