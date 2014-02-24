using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueAPI.Champion.Models.DTO;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Champion;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueAPI.Champion.Services
{
    public class ChampionService : BaseService, IChampionService
    {
        public ChampionService(
            ILeagueAPI source)
            : base(source, VersionEnum.V1Rev1, "champion")
        {
            Models.Champion.CreateMap(AutoMapperService, source);
        }

        public async Task<IEnumerable<IChampion>> GetChampionsAsync(
            bool freeToPlay,
            RegionEnum? region = null)
        {
            var url = string.Format("?freeToPlay={0}",
                freeToPlay);

            return await GetResponseAsync<ChampionListDto, IEnumerable<IChampion>>(region, url);
        }
    }
}