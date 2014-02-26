using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Static.Models.DTO;

namespace PortableLeagueApi.Static.Models
{
    public class ItemRune : ApiModel, IItemRune
    {
        public bool IsRune { get; set; }
        public int Tier { get; set; }
        public string Type { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<ItemRuneDto, ItemRune, IItemRune>();
        }
    }
}
