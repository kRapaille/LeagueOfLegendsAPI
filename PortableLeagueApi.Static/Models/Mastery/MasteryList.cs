using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Mastery;
using PortableLeagueApi.Static.Models.DTO.Mastery;

namespace PortableLeagueApi.Static.Models.Mastery
{
    public class MasteryList : ApiModel, IMasteryList
    {
        public IDictionary<string, IMastery> Data { get; set; }

        public IMasteryTree Tree { get; set; }
        public string Type { get; set; }

        public string Version { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Mastery.CreateMap(autoMapperService);
            MasteryTree.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<MasteryListDto, MasteryList, IMasteryList>();
        }
    }
}