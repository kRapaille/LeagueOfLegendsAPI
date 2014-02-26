using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Game.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.Team;

namespace PortableLeagueApi.Game.Extensions
{
    public static class RecentGamesExtensions
    {
        private static async Task<IEnumerable<IGame>> GetRecentGamesAsync(
            IApiModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            var gameService = new GameService(leagueModel.ApiConfiguration);
            return await gameService.GetRecentGamesBySummonerIdAsync(summonerId, region);
        }

        /// <summary>
        /// Get recent games
        /// </summary>
        public static async Task<IEnumerable<IGame>> GetRecentGamesAsync(
            this IHasSummonerId summoner,
            RegionEnum? region = null)
        {
            return await GetRecentGamesAsync(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Get recent games
        /// </summary>
        public static async Task<IEnumerable<IGame>> GetRecentGamesAsync(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await GetRecentGamesAsync(roster, roster.OwnerId, region);
        }
    }
}
