using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models
{
    public class Block : LeagueApiModel, IBlock
    {
        public IBlockItem[] Items { get; set; }

        public string Type { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<BlockDto, IBlock>().As<Block>();
            autoMapperService.CreateApiModelMap<BlockDto, Block>();
        }
    }
}
