using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Mastery;
using PortableLeagueApi.Static.Models.DTO.Mastery;

namespace PortableLeagueApi.Static.Models.Mastery
{
    public class MasteryTreeList : ApiModel, IMasteryTreeList
    {
        public IList<IMasteryTreeItem> MasteryTreeItems { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            MasteryTreeItem.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<MasteryTreeListDto, MasteryTreeList, IMasteryTreeList>();
        }
    }
}
