using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class TeamStatSummary : LeagueApiModel, ITeamStatSummary
    {
        public string FullId { get; set; }

        public IList<ITeamStatDetail> TeamStatDetails { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            TeamStatDetail.CreateMap(autoMapperService, source);

            autoMapperService.CreateMap<TeamStatSummaryDto, ITeamStatSummary>().As<TeamStatSummary>();
            autoMapperService.CreateMap<TeamStatSummaryDto, TeamStatSummary>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}