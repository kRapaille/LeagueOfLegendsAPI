using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class TeamStatSummary : LeagueApiModel, ITeamStatSummary
    {
        public string FullId { get; set; }

        public IList<ITeamStatDetail> TeamStatDetails { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            TeamStatDetail.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMap<TeamStatSummaryDto, ITeamStatSummary>().As<TeamStatSummary>();
            autoMapperService.CreateApiModelMap<TeamStatSummaryDto, TeamStatSummary>();
        }
    }
}