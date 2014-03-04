using System;
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
        private static async Task<IRankedStats> GetRankedStatsSummariesAsync(
            IApiModel leagueModel,
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            if (leagueModel == null) throw new ArgumentNullException("leagueModel");

            var statsService = new StatsService(leagueModel.ApiConfiguration);
            return await statsService.GetRankedStatsSummariesBySummonerIdAsync(summonerId, season, region);
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public static async Task<IRankedStats> GetRankedStatsSummariesAsync(
            this IHasSummonerId summoner,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetRankedStatsSummariesAsync(summoner, summoner.SummonerId, season, region);
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public static async Task<IRankedStats> GetRankedStatsSummariesAsync(
            this IRoster roster,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetRankedStatsSummariesAsync(roster, roster.OwnerId, season, region);
        }
    }
}
