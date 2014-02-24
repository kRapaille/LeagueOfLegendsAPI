using System.Collections.Generic;
using System.Linq;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
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

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            LeagueItem.CreateMap(autoMapperService, source);

            autoMapperService.CreateMap<string, LeagueTypeEnum>()
                .ConvertUsing(x => LeagueTypeConsts.LeagueTypes.First(z => z.Value == x).Key);

            autoMapperService.CreateMap<string, TierEnum>()
                .ConvertUsing(x => TierConsts.Tiers.First(z => z.Value == x).Key);

            autoMapperService.CreateMap<LeagueDto, ILeague>().As<League>();
            autoMapperService.CreateMap<LeagueDto, League>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}
