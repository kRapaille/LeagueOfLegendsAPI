using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Interfaces.Team;

namespace PortableLeagueApi.Interfaces.Stats
{
    public static class RankedStatsSummariesExtensions
    {
        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        private static async Task<IRankedStats> GetRankedStatsSummaries(
            ILeagueModel leagueModel,
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.Stats.GetRankedStatsSummariesBySummonerIdAsync(summonerId, season, region);
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public static async Task<IRankedStats> GetRankedStatsSummaries(
            this ISummoner summoner,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetRankedStatsSummaries(summoner, summoner.SummonerId, season, region);
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public static async Task<IRankedStats> GetRankedStatsSummaries(
            this ITeamMemberInfo teamMemberInfo,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetRankedStatsSummaries(teamMemberInfo, teamMemberInfo.SummonerId, season, region);
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public static async Task<IRankedStats> GetRankedStatsSummaries(
            this IRankedStats rankedStats,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetRankedStatsSummaries(rankedStats, rankedStats.SummonerId, season, region);
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public static async Task<IRankedStats> GetRankedStatsSummaries(
            this IPlayer player,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            return await GetRankedStatsSummaries(player, player.SummonerId, season, region);
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
