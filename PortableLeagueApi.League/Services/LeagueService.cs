using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.League.Models.League;

namespace PortableLeagueApi.League.Services
{
    public class LeagueService : BaseService
    {
        private LeagueService() : base(VersionEnum.V2Rev3, "league") { }

        private static LeagueService _instance;

        public static LeagueService Instance
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
