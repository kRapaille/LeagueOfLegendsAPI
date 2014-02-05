using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Stats.Enums;
using PortableLeagueApi.Stats.Models.Stats;

namespace PortableLeagueApi.Stats.Services
{
    public class StatsService : BaseService
    {
        private StatsService() : base(VersionEnum.V1Rev2, "stats") { }

        private static StatsService _instance;

        public static StatsService Instance
        {
            get { return _instance ?? (_instance = new StatsService()); }
        }

        public async Task<IEnumerable<PlayerStatsSummaryDto>> GetPlayerStatsSummariesBySummonerId(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/summary",
                summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            var playerStatvalueRoot = await GetResponse<PlayerStatsSummaryListDto>(region, url);

            return playerStatvalueRoot.PlayerStatSummaries.AsEnumerable();
        }

        public async Task<RankedStatsDto> GetRankedStatsSummariesBySummonerId(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/ranked",
                summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            var rankedStatsRoot = await GetResponse<RankedStatsDto>(region, url);

            return rankedStatsRoot;
        }
    }
}
