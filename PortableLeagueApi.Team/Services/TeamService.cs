using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Team.Models.Team;

namespace PortableLeagueApi.Team.Services
{
    public class TeamService : BaseService
    {
        public TeamService(
            ILeagueAPI source)
            : base(source, VersionEnum.V2Rev2, "team")
        { }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public async Task<IEnumerable<TeamDto>> GetTeamsBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                summonerId);

            return await GetResponseAsync<List<TeamDto>>(region, url);
        }

        /// <summary>
        /// Get teams mapped by team ID for a given list of team IDs
        /// </summary>
        public async Task<Dictionary<string, TeamDto>> GetTeamsByTeamIdsAsync(
            IEnumerable<string> teamIds,
            RegionEnum? region = null)
        {
            var url = string.Join(",", teamIds);

            return await GetResponseAsync<Dictionary<string, TeamDto>>(region, url);
        }

        /// <summary>
        /// Get team for a given team ID
        /// </summary>
        public async Task<TeamDto> GetTeamByTeamIdAsync(
            string teamId,
            RegionEnum? region = null)
        {
            var response = await GetTeamsByTeamIdsAsync(new[] {teamId}, region);

            return response[teamId];
        }
    }
}
