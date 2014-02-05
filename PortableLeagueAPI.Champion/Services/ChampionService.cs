using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Champion.Models.Champion;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Services;

namespace PortableLeagueAPI.Champion.Services
{
    public class ChampionService : BaseService
    {
        private ChampionService(): base(VersionEnum.V1Rev1, "champion") { }

        private static ChampionService _instance;
        
        public static ChampionService Instance
        {
            get { return _instance ?? (_instance = new ChampionService()); }
        }

        public async Task<IEnumerable<ChampionDto>> GetChampions(
            bool freeToPlay,
            RegionEnum? region = null)
        {
            var url = string.Format("?freeToPlay={0}",
                freeToPlay);

            var championsRoot = await GetResponse<ChampionListDto>(region, url);

            return championsRoot.Champions.AsEnumerable();
        }
    }
}