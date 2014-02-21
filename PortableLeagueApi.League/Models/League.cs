using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Models;
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

        internal static void CreateMap(ILeagueAPI source)
        {
            LeagueItem.CreateMap(source);

            Mapper.CreateMap<string, LeagueTypeEnum>()
                .ConvertUsing(x => LeagueTypeConsts.LeagueTypes.First(z => z.Value == x).Key);

            Mapper.CreateMap<string, TierEnum>()
                .ConvertUsing(x => TierConsts.Tiers.First(z => z.Value == x).Key);

            Mapper.CreateMap<LeagueDto, ILeague>().As<League>();
            Mapper.CreateMap<LeagueDto, League>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}
