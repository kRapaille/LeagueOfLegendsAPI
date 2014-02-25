using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class TeamStatDetail : LeagueApiModel, ITeamStatDetail
    {
        public int AverageGamesPlayed { get; set; }

        public string FullId { get; set; }

        public int Losses { get; set; }

        public string TeamStatType { get; set; }
        
        public int Wins { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<TeamStatDetailDto, ITeamStatDetail>().As<TeamStatDetail>();
            autoMapperService.CreateApiModelMap<TeamStatDetailDto, TeamStatDetail>();
        }
    }
}