using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Team;

namespace PortableLeagueAPI.Services
{
    public class TeamService : BaseService
    {
        private TeamService() : base(VersionEnum.V2Rev2) { }

        private static TeamService _instance;

        internal static TeamService Instance
        {
            get { return _instance ?? (_instance = new TeamService()); }
        }

        public async Task<IEnumerable<Team>> GetTeamsBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("team/by-summoner/{0}",
                summonerId);

            return await GetResponse<List<Team>>(region, url);
        }
    }
}
