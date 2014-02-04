using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.League;

namespace PortableLeagueAPI.Services
{
    public class LeagueService : BaseService
    {
        private LeagueService() : base(VersionEnum.V2Rev3, "league") { }

        private static LeagueService _instance;

        internal static LeagueService Instance
        {
            get { return _instance ?? (_instance = new LeagueService()); }
        }

        public async Task<List<LeagueDto>> GetLeagueInfosBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                summonerId);

            return await GetResponse<List<LeagueDto>>(region, url);
        }
    }
}
