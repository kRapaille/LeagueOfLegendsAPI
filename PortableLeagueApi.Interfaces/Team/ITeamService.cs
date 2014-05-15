using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface ITeamService
    {
        /// <summary>
        /// Retrieves teams
        /// </summary>
        Task<IEnumerable<ITeam>> GetTeamsBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves teams
        /// </summary>
        Task<IDictionary<string, IEnumerable<ITeam>>> GetTeamsBySummonerIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null);

        /// <summary>
        /// Get teams mapped by team ID for a given list of team IDs
        /// </summary>
        Task<Dictionary<string, ITeam>> GetTeamsByTeamIdsAsync(
            IEnumerable<string> teamIds,
            RegionEnum? region = null);

        /// <summary>
        /// Get team for a given team ID
        /// </summary>
        Task<ITeam> GetTeamByTeamIdAsync(
            string teamId,
            RegionEnum? region = null);
    }
}