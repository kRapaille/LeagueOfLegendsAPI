using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Game.Models.DTO;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;

namespace PortableLeagueApi.Game.Models
{
    public class Game : LeagueApiModel, IGame
    {
        public int GameId { get; set; }
        public IList<IPlayer> OtherPlayers { get; set; }
        public GameTypeEnum GameType { get; set; }
        public IList<int> SummonerSpells { get; set; }
        public int TeamId { get; set; }
        public IRawStats Stats { get; set; }
        public GameModeEnum GameMode { get; set; }
        public MapEnum Map { get; set; }
        public int Level { get; set; }
        public bool Invalid { get; set; }
        public GameSubTypeEnum GameSubType { get; set; }
        public int ChampionId { get; set; }
        public DateTime CreateDate { get; set; }

        internal static void CreateMap(ILeagueAPI source)
        {
            Player.CreateMap(source);
            RawStats.CreateMap(source);

            Mapper.CreateMap<string, GameTypeEnum>()
                .ConvertUsing(s => GameTypeConsts.GameTypes
                    .First(x => x.Value == s).Key);

            Mapper.CreateMap<string, GameModeEnum>()
                .ConvertUsing(s => GameModeConsts.GameModes
                    .First(x => x.Value == s).Key);

            Mapper.CreateMap<string, GameSubTypeEnum>()
                .ConvertUsing(s => GameSubTypeConsts.GameSubTypes
                    .First(x => x.Value == s).Key);

            Mapper.CreateMap<GameDto, IGame>().As<Game>();
            Mapper.CreateMap<GameDto, Game>()
                .ForMember(x => x.OtherPlayers, x => x.MapFrom(g => g.FellowPlayers))
                .ForSourceMember(x => x.SummonerSpell1, x => x.Ignore())
                .ForSourceMember(x => x.SummonerSpell2, x => x.Ignore())
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                    d.Map = (MapEnum) s.MapId;

                    d.SummonerSpells = new List<int>
                                        {
                                            s.SummonerSpell1,
                                            s.SummonerSpell2
                                        };
                });

            Mapper.CreateMap<RecentGamesDto, IEnumerable<IGame>>()
                .ConvertUsing(x => x.Games.Select(Mapper.Map<GameDto, IGame>));
        }
    }
}
