using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Game.Models.DTO;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Game;

namespace PortableLeagueApi.Game.Models
{
    public class Player : LeagueApiModel, IPlayer
    {
        public int ChampionId { get; set; }
        public int TeamId { get; set; }
        public long SummonerId { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            autoMapperService.CreateMap<PlayerDto, IPlayer>().As<Player>();
            autoMapperService.CreateMap<PlayerDto, Player>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });
        }
    }
}
