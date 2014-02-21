using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces;
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
    }
}
