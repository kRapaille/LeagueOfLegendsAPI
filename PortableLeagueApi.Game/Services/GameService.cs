using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Game.Models.Game;

namespace PortableLeagueApi.Game.Services
{
    public class GameService : BaseService
    {
        public GameService(
            string key,
            IHttpRequestService httpRequestService, 
            RegionEnum? defaultRegion, 
            bool waitToAvoidRateLimit) 
            : base(key, httpRequestService, VersionEnum.V1Rev3, "game", defaultRegion, waitToAvoidRateLimit)
        { }

        /// <summary>
        /// Get recent games
        /// </summary>
        public async Task<IEnumerable<GameDto>> GetRecentGamesBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/recent",
                summonerId);

            var recentGamesRoot = await GetResponseAsync<RecentGamesDto>(region, url);

            return recentGamesRoot.Games.AsEnumerable();
        }
    }
}
