using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class Roster : LeagueApiModel, IRoster
    {
        public IList<ITeamMemberInfo> MemberList { get; set; }

        public int OwnerId { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            TeamMemberInfo.CreateMap(autoMapperService, source);

            autoMapperService.CreateMap<RosterDto, IRoster>().As<Roster>();
            autoMapperService.CreateMap<RosterDto, Roster>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}