using System.Collections.Generic;
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
            : base(config, VersionEnum.V2Rev2, "team")
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
            var url = string.Format("by-summoner/{0}",
                summonerId);

            return await GetResponseAsync<IEnumerable<TeamDto>, IEnumerable<ITeam>>(region, url);
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
