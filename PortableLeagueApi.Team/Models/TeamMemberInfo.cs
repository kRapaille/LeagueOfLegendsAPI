using System;
using AutoMapper;
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
            CreateMap<TeamMemberInfo>(autoMapperService);
            CreateMap<ITeamMemberInfo>(autoMapperService).As<TeamMemberInfo>();
        }

        private static IMappingExpression<TeamMemberInfoDto, T> CreateMap<T>(AutoMapperService autoMapperService)
            where T : ITeamMemberInfo
        {
            return autoMapperService.CreateApiModelMap<TeamMemberInfoDto, T>()
                .ForMember(x => x.SummonerId, x => x.MapFrom(z => z.PlayerId));
        }
    }
}