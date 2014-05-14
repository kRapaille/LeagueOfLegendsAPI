using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Services
{
    public class TeamService : BaseService, ITeamService
    {
        public TeamService(
            ILeagueApiConfiguration config)
            : base(config, VersionEnum.V2Rev3, "team")
        {
            Models.Team.CreateMap(AutoMapperService);

#if DEBUG
            AutoMapperService.AssertConfigurationIsValid();
#endif
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public async Task<IEnumerable<ITeam>> GetTeamsBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetTeamsBySummonerIdAsync(new[] {summonerId}, region);

            return result.Values.FirstOrDefault();
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public async Task<IDictionary<string, IEnumerable<ITeam>>> GetTeamsBySummonerIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                string.Join(",", summonerIds));

            return await GetResponseAsync <IDictionary<string, IEnumerable<TeamDto>>, IDictionary<string, IEnumerable<ITeam>>>(region, url);
        }

        /// <summary>
        /// Get teams mapped by team ID for a given list of team IDs
        /// </summary>
        public async Task<Dictionary<string, ITeam>> GetTeamsByTeamIdsAsync(
            IEnumerable<string> teamIds,
            RegionEnum? region = null)
        {
            var url = string.Join(",", teamIds);

            return await GetResponseAsync<Dictionary<string, TeamDto>, Dictionary<string, ITeam>>(region, url);
        }

        /// <summary>
        /// Get team for a given team ID
        /// </summary>
        public async Task<ITeam> GetTeamByTeamIdAsync(
            string teamId,
            RegionEnum? region = null)
        {
            var response = await GetTeamsByTeamIdsAsync(new[] {teamId}, region);

            return response[teamId];
        }
    }
}
