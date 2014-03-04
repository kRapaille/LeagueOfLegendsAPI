using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Stats.Services;

namespace PortableLeagueApi.Stats.Extensions
{
    public static class PlayerStatsSummariesExtensions
    {
        private static async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummariesAsync(
            IApiModel leagueModel,
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            if (leagueModel == null) throw new ArgumentNullException("leagueModel");

            var statsService = new StatsService(leagueModel.ApiConfiguration);
            return await statsService.GetPlayerStatsSummariesBySummonerIdAsync(summonerId, season, region);
        }

        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        public static async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummariesAsync(
            this IHasSummonerId summoner,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetPlayerStatsSummariesAsync(summoner, summoner.SummonerId, season, region);
        }

        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        public static async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummariesAsync(
            this IRoster roster,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetPlayerStatsSummariesAsync(roster, roster.OwnerId, season, region);
        }
    }
}
