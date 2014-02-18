using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Game.Models.Game;

namespace PortableLeagueApi.Game.Services
{
    public class GameService : BaseService
    {
        private GameService() : base(VersionEnum.V1Rev3, "game") { }

        private static GameService _instance;

        public static GameService Instance
        {
            get { return _instance ?? (_instance = new GameService()); }
        }

        /// <summary>
        /// Get recent games
        /// </summary>
        public async Task<IEnumerable<GameDto>> GetRecentGamesBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/recent",
                summonerId);

            var recentGamesRoot = await GetResponse<RecentGamesDto>(region, url);

            return recentGamesRoot.Games.AsEnumerable();
        }
    }
}
