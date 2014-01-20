using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Models.Champion;
using PortableLeagueAPI.Models.Enums;

namespace PortableLeagueAPI.Services
{
    public class ChampionService : BaseService
    {
        private ChampionService():base(VersionEnum.V1Rev1, "champion") { }

        private static ChampionService _instance;
        
        internal static ChampionService Instance
        {
            get { return _instance ?? (_instance = new ChampionService()); }
        }

        public async Task<IEnumerable<Champion>> GetChampions(
            bool freeToPlay,
            RegionEnum? region = null)
        {
            var url = string.Format("?freeToPlay={0}",
                freeToPlay);

            var championsRoot = await GetResponse<ChampionsRoot>(region, url);

            return championsRoot.Champions.AsEnumerable();
        }
    }
}