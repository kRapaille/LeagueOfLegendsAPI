using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Static.Models.DTO.Item;

namespace PortableLeagueApi.Static.Models.Item
{
    public class ItemTree : ApiModel, IItemTree
    {
        public string Header { get; set; }

        public IList<string> Tags { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<ItemTreeDto, ItemTree, IItemTree>();
        }
    }
}
