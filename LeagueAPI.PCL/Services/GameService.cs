using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Game;

namespace PortableLeagueAPI.Services
{
    public class GameService : BaseService
    {
        private GameService() : base(VersionEnum.V1Rev3, "game") { }

        private static GameService _instance;

        internal static GameService Instance
        {
            get { return _instance ?? (_instance = new GameService()); }
        }

        public async Task<IEnumerable<Game>> GetRecentGamesBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/recent",
                summonerId);

            var recentGamesRoot = await GetResponse<RecentGamesRoot>(region, url);

            return recentGamesRoot.Games.AsEnumerable();
        }
    }
}
