using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Models;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Game;

namespace PortableLeagueAPI.Services
{
    public class GameService : BaseService
    {
        private GameService()
        {
            CompatibleVersions = new[]
            {
                VersionEnum.V1Rev1,
                VersionEnum.V1Rev2,
                VersionEnum.V1Rev3
            };
        }

        private static GameService _instance;

        internal static GameService Instance
        {
            get { return _instance ?? (_instance = new GameService()); }
        }

        public async Task<IEnumerable<Game>> GetRecentGamesBySummonerId(
            long summonerId,
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            var url = string.Format("lol/{0}/{1}/game/by-summoner/{2}/recent",
                GetRegionAsString(region),
                GetVersionAsString(version), 
                summonerId);

            var recentGamesRoot = await GetResponse<RecentGamesRoot>(url);

            return recentGamesRoot.Games.AsEnumerable();
        }
    }
}
