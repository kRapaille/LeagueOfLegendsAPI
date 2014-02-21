using AutoMapper;
using PortableLeagueApi.Core.Models;
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

        internal static void CreateMap(ILeagueAPI source)
        {
            Mapper.CreateMap<PlayerDto, IPlayer>().As<Player>();
            Mapper.CreateMap<PlayerDto, Player>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });
        }
    }
}
