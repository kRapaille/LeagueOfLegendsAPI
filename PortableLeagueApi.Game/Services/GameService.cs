using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Game.Models.DTO;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;

namespace PortableLeagueApi.Game.Services
{
    public class GameService : BaseService, IGameService
    {
        public GameService(
            ILeagueApiConfiguration config)
            : base(config, VersionEnum.V1Rev3, "game")
        {
            Models.Game.CreateMap(AutoMapperService);

#if DEBUG
            AutoMapperService.AssertConfigurationIsValid();
#endif
        }

        /// <summary>
        /// Get recent games
        /// </summary>
        public async Task<IEnumerable<IGame>> GetRecentGamesBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/recent",
                summonerId);

            return await GetResponseAsync<RecentGamesDto, IEnumerable<IGame>>(region, url);
        }
    }
}
