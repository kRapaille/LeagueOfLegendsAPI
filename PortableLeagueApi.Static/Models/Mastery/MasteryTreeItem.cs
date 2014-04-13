using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Mastery;
using PortableLeagueApi.Static.Models.DTO.Mastery;

namespace PortableLeagueApi.Static.Models.Mastery
{
    public class MasteryTreeItem : ApiModel, IMasteryTreeItem
    {
        public int MasteryId { get; set; }
        public string Prereq { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<MasteryTreeItemDto, MasteryTreeItem, IMasteryTreeItem>();
        }
    }
}
