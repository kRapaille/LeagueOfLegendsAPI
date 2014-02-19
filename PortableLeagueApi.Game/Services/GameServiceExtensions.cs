using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Game.Models.Game;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Game.Services
{
    public static class GameServiceExtensions
    {
        /// <summary>
        /// Get recent games
        /// </summary>
        public static async Task<IEnumerable<GameDto>> GetRecentGames(
            this ISummoner summoner,
            GameService gameService,
            RegionEnum? region = null)
        {
            return await gameService.GetRecentGamesBySummonerIdAsync(summoner.SummonerId, region);
        }
    }
}
