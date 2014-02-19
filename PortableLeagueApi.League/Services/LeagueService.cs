using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.League.Enums;
using PortableLeagueApi.League.Models.League;

namespace PortableLeagueApi.League.Services
{
    public class LeagueService : BaseService
    {
        public LeagueService(
            string key,
            IHttpRequestService httpRequestService, 
            RegionEnum? defaultRegion, 
            bool waitToAvoidRateLimit) 
            : base(key, httpRequestService, VersionEnum.V2Rev3, "league", defaultRegion, waitToAvoidRateLimit)
        { }

        /// <summary>
        /// Retrieves challenger tier leagues.
        /// </summary>
        public async Task<LeagueDto> RetrievesChallengerTierLeaguesAsync(
            LeagueTypeEnum leagueType,
            RegionEnum? region = null)
        {
            var url = string.Format("challenger?type={0}", leagueType);

            return await GetResponseAsync<LeagueDto>(region, url);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public async Task<List<LeagueItemDto>> RetrievesLeaguesEntryDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/entry",
                summonerId);

            return await GetResponseAsync<List<LeagueItemDto>>(region, url);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public async Task<List<LeagueDto>> RetrievesLeaguesDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                summonerId);

            return await GetResponseAsync<List<LeagueDto>>(region, url);
        }
    }
}
