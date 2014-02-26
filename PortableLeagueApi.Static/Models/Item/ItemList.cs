using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Static.Models.DTO.Item;

namespace PortableLeagueApi.Static.Models.Item
{
    public class ItemList : ApiModel, IItemList
    {
        public IBasicData Basic { get; set; }

        public IDictionary<string, IItem> Data { get; set; }

        public IList<IGroup> Groups { get; set; }

        public IList<IItemTree> Tree { get; set; }

        public string Type { get; set; }

        public string Version { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            BasicData.CreateMap(autoMapperService);
            Item.CreateMap(autoMapperService);
            Group.CreateMap(autoMapperService);
            ItemTree.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<ItemListDto, ItemList, IItemList>();
        }
    }
}