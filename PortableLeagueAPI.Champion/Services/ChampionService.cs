using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Champion.Models.Champion;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Services;

namespace PortableLeagueAPI.Champion.Services
{
    public class ChampionService : BaseService
    {
        public ChampionService(
            string key,
            IHttpRequestService httpRequestService,
            RegionEnum? defaultRegion, 
                bool waitToAvoidRateLimit) 
            : base(key, httpRequestService, VersionEnum.V1Rev1, "champion", defaultRegion, waitToAvoidRateLimit)
        { }

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