using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Game.Models.DTO;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;

namespace PortableLeagueApi.Game.Models
{
    public class Game : ApiModel, IGame
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

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Player.CreateMap(autoMapperService);
            RawStats.CreateMap(autoMapperService);

            autoMapperService.CreateMap<string, GameTypeEnum>()
                .ConvertUsing(s => GameTypeConsts.GameTypes
                    .First(x => x.Value == s).Key);

            autoMapperService.CreateMap<string, GameModeEnum>()
                .ConvertUsing(s => GameModeConsts.GameModes
                    .First(x => x.Value == s).Key);

            autoMapperService.CreateMap<string, GameSubTypeEnum>()
                .ConvertUsing(s => GameSubTypeConsts.GameSubTypes
                    .First(x => x.Value == s).Key);

            CreateMap<Game>(autoMapperService);
            CreateMap<IGame>(autoMapperService).As<Game>();

            autoMapperService.CreateMap<RecentGamesDto, IEnumerable<IGame>>()
                .ConvertUsing(x => x.Games.Select(autoMapperService.Map<GameDto, IGame>));
        }

        private static IMappingExpression<GameDto, T> CreateMap<T>(AutoMapperService autoMapperService)
            where T : IGame
        {
            return autoMapperService.CreateApiModelMap<GameDto, T>()
                .ForMember(x => x.OtherPlayers, x => x.MapFrom(g => g.FellowPlayers))
                .ForMember(x => x.GameSubType, x => x.MapFrom(g => g.SubType))
                .ForMember(x => x.SummonerSpells, x => x.Ignore())
                .ForMember(x => x.Map, x => x.Ignore())
                .ForSourceMember(x => x.SummonerSpell1, x => x.Ignore())
                .ForSourceMember(x => x.SummonerSpell2, x => x.Ignore())
                .BeforeMap((s, d) =>
                {
                    d.Map = (MapEnum)s.MapId;

                    d.SummonerSpells = new List<int>
                                        {
                                            s.SummonerSpell1,
                                            s.SummonerSpell2
                                        };
                });
        }
    }
}
