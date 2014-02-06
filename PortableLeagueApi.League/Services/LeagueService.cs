using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.League.Enums;
using PortableLeagueApi.League.Models.League;

namespace PortableLeagueApi.League.Services
{
    public class LeagueService : BaseService
    {
        private LeagueService() : base(VersionEnum.V2Rev3, "league") { }

        private static LeagueService _instance;

        public static LeagueService Instance
        {
            get { return _instance ?? (_instance = new LeagueService()); }
        }

        /// <summary>
        /// Retrieves challenger tier leagues.
        /// </summary>
        public async Task<LeagueDto> RetrievesChallengerTierLeagues(
            LeagueTypeEnum leagueType,
            RegionEnum? region = null)
        {
            var url = string.Format("challenger?type={0}", leagueType);

            return await GetResponse<LeagueDto>(region, url);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public async Task<List<LeagueItemDto>> RetrievesLeaguesEntryDataForSummoner(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/entry",
                summonerId);

            return await GetResponse<List<LeagueItemDto>>(region, url);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public async Task<List<LeagueDto>> RetrievesLeaguesDataForSummoner(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                summonerId);

            return await GetResponse<List<LeagueDto>>(region, url);
        }
    }
}
