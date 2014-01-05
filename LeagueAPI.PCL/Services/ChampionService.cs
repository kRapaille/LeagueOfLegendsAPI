using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Models;
using PortableLeagueAPI.Models.Enums;

namespace PortableLeagueAPI.Services
{
    public class ChampionService : BaseService
    {
        private ChampionService() { }

        private static ChampionService _instance;

        internal static ChampionService Instance
        {
            get { return _instance ?? (_instance = new ChampionService()); }
        }

        public async Task<IEnumerable<Champion>> GetChampions(
            bool freeToPlay,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/champion?freeToPlay={1}", GetRegion(region), freeToPlay);

            var championsRoot = await GetResponse<ChampionsRoot>(url);

            return championsRoot.Champions.AsEnumerable();
        }
    }
}