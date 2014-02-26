using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PortableLeagueAPI.Champion.Models.DTO;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Champion;

namespace PortableLeagueAPI.Champion.Models
{
    public class Champion : ApiModel, IChampion
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

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            CreateMap<Champion>(autoMapperService);
            CreateMap<IChampion>(autoMapperService).As<Champion>();
            
            autoMapperService.CreateMap<ChampionListDto, IEnumerable<IChampion>>()
                .ConvertUsing(x => x.Champions.Select(autoMapperService.Map<ChampionDto, IChampion>));
        }

        private static IMappingExpression<ChampionDto, T> CreateMap<T>(AutoMapperService autoMapperService)
            where T : IChampion
        {
            return autoMapperService.CreateApiModelMap<ChampionDto, T>()
                .ForMember(x => x.IsBotMatchMadeEnabled, x => x.MapFrom(z => z.BotMmEnabled))
                .ForMember(x => x.IsBotEnabledForCustomGames, x => x.MapFrom(z => z.BotEnabled))
                .ForMember(x => x.IsAvailableInRanked, x => x.MapFrom(z => z.RankedPlayEnabled))
                .ForMember(x => x.IsActive, x => x.MapFrom(z => z.Active))
                .ForMember(x => x.IsFreeToPlay, x => x.MapFrom(z => z.FreeToPlay));
        }
    }
}
