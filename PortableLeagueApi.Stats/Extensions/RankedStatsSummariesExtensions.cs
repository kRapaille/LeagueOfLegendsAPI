using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Stats.Services;

namespace PortableLeagueApi.Stats.Extensions
{
    public static class RankedStatsSummariesExtensions
    {
        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        private static async Task<IRankedStats> GetRankedStatsSummaries(
            IApiModel leagueModel,
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var statsService = new StatsService(leagueModel.ApiConfiguration);
            return await statsService.GetRankedStatsSummariesBySummonerIdAsync(summonerId, season, region);
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public static async Task<IRankedStats> GetRankedStatsSummaries(
            this IHasSummonerId summoner,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetRankedStatsSummaries(summoner, summoner.SummonerId, season, region);
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public static async Task<IRankedStats> GetRankedStatsSummaries(
            this IRoster roster,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetRankedStatsSummaries(roster, roster.OwnerId, season, region);
        }
    }
}
