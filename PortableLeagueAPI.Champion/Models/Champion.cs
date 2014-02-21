using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PortableLeagueAPI.Champion.Models.DTO;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Champion;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueAPI.Champion.Models
{
    public class Champion : LeagueApiModel, IChampion
    {
        public int ChampionId { get; set; }
        public string Name { get; set; }

        public bool IsBotMatchMadeEnabled { get; set; }
        public bool IsBotEnabledForCustomGames { get; set; }
        public bool IsAvailableInRanked { get; set; }
        public bool IsActive { get; set; }
        public bool IsFreeToPlay { get; set; }

        public int MagicRank { get; set; }
        public int DefenseRank { get; set; }
        public int AttackRank { get; set; }
        public int DifficultyRank { get; set; }

        internal static void CreateMap(ILeagueAPI source)
        {
            Mapper.CreateMap<ChampionDto, IChampion>().As<Champion>();
            Mapper.CreateMap<ChampionDto, Champion>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });

            Mapper.CreateMap<ChampionListDto, IEnumerable<IChampion>>()
                .ConvertUsing(x => x.Champions.Select(Mapper.Map<ChampionDto, IChampion>));
        }
    }
}
