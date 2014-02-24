using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Interfaces.Team;

namespace PortableLeagueApi.Interfaces.Game
{
    public static class RecentGamesExtensions
    {
        private static async Task<IEnumerable<IGame>> GetRecentGames(
            ILeagueModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.Game.GetRecentGamesBySummonerIdAsync(summonerId, region);
        }

        /// <summary>
        /// Get recent games
        /// </summary>
        public static async Task<IEnumerable<IGame>> GetRecentGames(
            this ISummoner summoner,
            RegionEnum? region = null)
        {
            return await GetRecentGames(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Get recent games
        /// </summary>
        public static async Task<IEnumerable<IGame>> GetRecentGames(
            this ITeamMemberInfo teamMemberInfo,
            RegionEnum? region = null)
        {
            return await GetRecentGames(teamMemberInfo, teamMemberInfo.SummonerId, region);
        }

        /// <summary>
        /// Get recent games
        /// </summary>
        public static async Task<IEnumerable<IGame>> GetRecentGames(
            this IRankedStats rankedStats,
            RegionEnum? region = null)
        {
            return await GetRecentGames(rankedStats, rankedStats.SummonerId, region);
        }

        /// <summary>
        /// Get recent games
        /// </summary>
        public static async Task<IEnumerable<IGame>> GetRecentGames(
            this IPlayer player,
            RegionEnum? region = null)
        {
            return await GetRecentGames(player, player.SummonerId, region);
        }

        /// <summary>
        /// Get recent games
        /// </summary>
        public static async Task<IEnumerable<IGame>> GetRecentGames(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await GetRecentGames(roster, roster.OwnerId, region);
        }
    }
}
