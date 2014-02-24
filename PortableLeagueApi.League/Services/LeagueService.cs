using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.League.Models.DTO;

namespace PortableLeagueApi.League.Services
{
    public class LeagueService : BaseService, ILeagueService
    {
        public LeagueService(
            ILeagueAPI source)
            : base(source, VersionEnum.V2Rev3, "league")
        {
            Models.League.CreateMap(AutoMapperService, source);
        }

        /// <summary>
        /// Retrieves challenger tier leagues.
        /// </summary>
        public async Task<ILeague> RetrievesChallengerTierLeaguesAsync(
            LeagueTypeEnum leagueType,
            RegionEnum? region = null)
        {
            var url = string.Format("challenger?type={0}", leagueType);

            return await GetResponseAsync<LeagueDto, ILeague>(region, url);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public async Task<IEnumerable<ILeagueItem>> RetrievesLeaguesEntryDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/entry",
                summonerId);

            return await GetResponseAsync<IEnumerable<LeagueItemDto>, IEnumerable<ILeagueItem>>(region, url);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public async Task<IEnumerable<ILeague>> RetrievesLeaguesDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                summonerId);

            return await GetResponseAsync<IEnumerable<LeagueDto>, IEnumerable<ILeague>>(region, url);
        }
    }
}
