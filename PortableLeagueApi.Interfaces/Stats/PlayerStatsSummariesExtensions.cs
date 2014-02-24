using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Interfaces.Team;

namespace PortableLeagueApi.Interfaces.Stats
{
    public static class PlayerStatsSummariesExtensions
    {
        private static async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummaries(
            ILeagueModel leagueModel,
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.Stats.GetPlayerStatsSummariesBySummonerIdAsync(summonerId, season, region);
        }

        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        public static async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummaries(
            this ISummoner summoner,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetPlayerStatsSummaries(summoner, summoner.SummonerId, season, region);
        }

        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        public static async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummaries(
            this ITeamMemberInfo teamMemberInfo,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetPlayerStatsSummaries(teamMemberInfo, teamMemberInfo.SummonerId, season, region);
        }

        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        public static async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummaries(
            this IRankedStats rankedStats,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetPlayerStatsSummaries(rankedStats, rankedStats.SummonerId, season, region);
        }

        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        public static async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummaries(
            this IPlayer player,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetPlayerStatsSummaries(player, player.SummonerId, season, region);
        }

        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        public static async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummaries(
            this IRoster roster,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetPlayerStatsSummaries(roster, roster.OwnerId, season, region);
        }
    }
}
