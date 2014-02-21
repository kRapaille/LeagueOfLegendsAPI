using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Stats.Enums;
using PortableLeagueApi.Stats.Models.Stats;

namespace PortableLeagueApi.Stats.Services
{
    public class StatsService : BaseService
    {
        public StatsService(
            ILeagueAPI source)
            : base(source, VersionEnum.V1Rev2, "stats")
        { }

        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        public async Task<IEnumerable<PlayerStatsSummaryDto>> GetPlayerStatsSummariesBySummonerIdAsync(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/summary",
                summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            var playerStatvalueRoot = await GetResponseAsync<PlayerStatsSummaryListDto>(region, url);

            return playerStatvalueRoot.PlayerStatSummaries.AsEnumerable();
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public async Task<RankedStatsDto> GetRankedStatsSummariesBySummonerIdAsync(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/ranked",
                summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            var rankedStatsRoot = await GetResponseAsync<RankedStatsDto>(region, url);

            return rankedStatsRoot;
        }
    }
}
