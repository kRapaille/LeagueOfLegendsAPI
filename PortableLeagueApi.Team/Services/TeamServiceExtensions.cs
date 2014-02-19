using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Team.Models.Team;

namespace PortableLeagueApi.Team.Services
{
    public static class TeamServiceExtensions
    {
        /// <summary>
        /// Retrieves teams
        /// </summary>
        public static async Task<IEnumerable<TeamDto>> GetTeamsBySummonerId(
            ISummoner summoner,
            TeamService teamService,
            RegionEnum? region = null)
        {
            return await teamService.GetTeamsBySummonerId(summoner.SummonerId, region);
        }
    }
}