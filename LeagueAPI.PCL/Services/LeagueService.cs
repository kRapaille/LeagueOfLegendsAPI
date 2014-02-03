using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.League;

namespace PortableLeagueAPI.Services
{
    public class LeagueService : BaseService
    {
        private LeagueService() : base(VersionEnum.V2Rev2, "league") { }

        private static LeagueService _instance;

        internal static LeagueService Instance
        {
            get { return _instance ?? (_instance = new LeagueService()); }
        }

        public async Task<Dictionary<string, LeagueDto>> GetLeagueInfosBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                summonerId);

            return await GetResponse<Dictionary<string, LeagueDto>>(region, url);
        }
    }
}
