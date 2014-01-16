using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Models;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Stats;

namespace PortableLeagueAPI.Services
{
    public class StatsService : BaseService
    {
        private StatsService()
        {
            CompatibleVersions = new[]
            {
                // TODO : Manage model versioning
                //VersionEnum.V1Rev1,
                VersionEnum.V1Rev2
            };
        }

        private static StatsService _instance;

        internal static StatsService Instance
        {
            get { return _instance ?? (_instance = new StatsService()); }
        }

        public async Task<IEnumerable<PlayerStatSummary>> GetPlayerStatsSummariesBySummonerId(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null,
            VersionEnum? verion = null)
        {
            var url = string.Format("lol/{0}/{1}/stats/by-summoner/{2}/summary",
                GetRegionAsString(region),
                GetVersionAsString(verion),
                summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            var playerStatSummaryRoot = await GetResponse<PlayerStatSummaryRoot>(url);

            return playerStatSummaryRoot.PlayerStatSummaries.AsEnumerable();
        }

        public async Task<RankedStats> GetRankedStatsSummariesBySummonerId(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null,
            VersionEnum? verion = null)
        {
            var url = string.Format("lol/{0}/{1}/stats/by-summoner/{2}/ranked", 
                GetRegionAsString(region), 
                GetVersionAsString(verion),
                summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            var rankedStatsRoot = await GetResponse<RankedStats>(url);

            return rankedStatsRoot;
        }
    }
}
