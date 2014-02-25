using System;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class TeamMemberInfo : ApiModel, ITeamMemberInfo
    {
        public DateTime InviteDate { get; set; }

        public DateTime JoinDate { get; set; }

        public long SummonerId { get; set; }
        
        public string Status { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<TeamMemberInfoDto, ITeamMemberInfo>().As<TeamMemberInfo>();
            autoMapperService.CreateApiModelMap<TeamMemberInfoDto, TeamMemberInfo>();
        }
    }
}