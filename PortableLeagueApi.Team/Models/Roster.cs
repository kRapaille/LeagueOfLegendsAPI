using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class Roster : LeagueApiModel, IRoster
    {
        public IList<ITeamMemberInfo> MemberList { get; set; }

        public long OwnerId { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            TeamMemberInfo.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<RosterDto, IRoster>().As<Roster>();
            autoMapperService.CreateApiModelMap<RosterDto, Roster>();
        }
    }
}