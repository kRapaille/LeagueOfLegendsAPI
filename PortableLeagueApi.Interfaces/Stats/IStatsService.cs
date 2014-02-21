using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IStatsService
    {
        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummariesBySummonerIdAsync(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null);

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        Task<IRankedStats> GetRankedStatsSummariesBySummonerIdAsync(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null);
    }
}