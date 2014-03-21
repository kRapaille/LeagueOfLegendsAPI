using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Mastery;
using PortableLeagueApi.Static.Models.DTO.Mastery;

namespace PortableLeagueApi.Static.Models.Mastery
{
    public class MasteryTree : ApiModel, IMasteryTree
    {
        public IList<IMasteryTreeList> Defense { get; set; }

        public IList<IMasteryTreeList> Offense { get; set; }

        public IList<IMasteryTreeList> Utility { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            MasteryTreeList.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<MasteryTreeDto, MasteryTree, IMasteryTree>();
        }
    }
}
