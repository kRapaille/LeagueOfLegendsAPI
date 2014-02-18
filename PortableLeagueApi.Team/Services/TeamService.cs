using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Team.Models.Team;

namespace PortableLeagueApi.Team.Services
{
    public class TeamService : BaseService
    {
        private TeamService() : base(VersionEnum.V2Rev2, "team") { }

        private static TeamService _instance;

        public static TeamService Instance
        {
            get { return _instance ?? (_instance = new TeamService()); }
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public async Task<IEnumerable<TeamDto>> GetTeamsBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                summonerId);

            return await GetResponse<List<TeamDto>>(region, url);
        }
    }
}
