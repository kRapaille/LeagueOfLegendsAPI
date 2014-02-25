using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.League.Models.DTO;

namespace PortableLeagueApi.League.Models
{
    public class League : LeagueApiModel, ILeague
    {
        public IList<ILeagueItem> LeagueItems { get; set; }
        public string Name { get; set; }
        public string ParticipantId { get; set; }
        public LeagueTypeEnum LeagueType { get; set; }
        public TierEnum Tier { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            LeagueItem.CreateMap(autoMapperService);

            autoMapperService.CreateMap<string, LeagueTypeEnum>()
                .ConvertUsing(x => LeagueTypeConsts.LeagueTypes.First(z => z.Value == x).Key);

            autoMapperService.CreateMap<string, TierEnum>()
                .ConvertUsing(x => TierConsts.Tiers.First(z => z.Value == x).Key);
            
            CreateMap<League>(autoMapperService);
            CreateMap<ILeague>(autoMapperService).As<League>();
        }

        private static IMappingExpression<LeagueDto, T> CreateMap<T>(AutoMapperService autoMapperService)
            where T : ILeague
        {
            return autoMapperService.CreateApiModelMap<LeagueDto, T>()
                .ForMember(x => x.LeagueItems, x => x.MapFrom(z => z.Entries))
                .ForMember(x => x.LeagueType, x => x.MapFrom(z => z.Queue));

        }
    }
}
