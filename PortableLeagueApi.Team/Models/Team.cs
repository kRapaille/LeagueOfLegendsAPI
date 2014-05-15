using System;
using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class Team : ApiModel, ITeam
    {
        public DateTime CreateDate { get; set; }

        public string FullId { get; set; }

        public DateTime LastGameDate { get; set; }

        public DateTime LastJoinDate { get; set; }

        public DateTime LastJoinedRankedTeamQueueDate { get; set; }

        public IList<IMatchHistorySummary> MatchHistory { get; set; }

        public DateTime ModifyDate { get; set; }

        public string Name { get; set; }

        public IRoster Roster { get; set; }

        public DateTime SecondLastJoinDate { get; set; }

        public string Status { get; set; }

        public string Tag { get; set; }

        public IList<ITeamStatDetail> TeamStatDetails { get; set; }

        public DateTime ThirdLastJoinDate { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            MatchHistorySummary.CreateMap(autoMapperService);
            Models.Roster.CreateMap(autoMapperService);
            TeamStatDetail.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<TeamDto, ITeam>().As<Team>();
            autoMapperService.CreateApiModelMap<TeamDto, Team>();
        }
    }
}
