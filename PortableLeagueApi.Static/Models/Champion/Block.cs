using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class Block : ApiModel, IBlock
    {
        public IBlockItem[] Items { get; set; }

        public string Type { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            BlockItem.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<BlockDto, Block, IBlock>();
        }
    }
}
