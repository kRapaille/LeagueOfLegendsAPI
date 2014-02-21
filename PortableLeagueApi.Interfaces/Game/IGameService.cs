using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Game
{
    public interface IGameService
    {
        /// <summary>
        /// Get recent games
        /// </summary>
        Task<IEnumerable<IGame>> GetRecentGamesBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null);
    }
}