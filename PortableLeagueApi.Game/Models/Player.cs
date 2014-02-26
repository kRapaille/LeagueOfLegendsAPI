using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Game.Models.DTO;
using PortableLeagueApi.Interfaces.Game;

namespace PortableLeagueApi.Game.Models
{
    public class Player : ApiModel, IPlayer
    {
        public int ChampionId { get; set; }
        public int TeamId { get; set; }
        public long SummonerId { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<PlayerDto, IPlayer>().As<Player>();
            autoMapperService.CreateApiModelMap<PlayerDto, Player>();
        }
    }
}
