using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models
{
    public class BlockItem : LeagueApiModel, IBlockItem
    {
        public string Id { get; set; }

        public int Count { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<BlockItemDto, IBlockItem>().As<BlockItem>();
            autoMapperService.CreateApiModelMap<BlockItemDto, BlockItem>();
        }
    }
}
