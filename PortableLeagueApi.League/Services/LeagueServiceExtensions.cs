using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.League.Models.League;

namespace PortableLeagueApi.League.Services
{
    public static class LeagueServiceExtensions
    {
        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public static async Task<List<LeagueItemDto>> RetrievesLeaguesEntryData(
            this ISummoner summoner,
            RegionEnum? region = null)
        {
            return await LeagueService.Instance.RetrievesLeaguesEntryDataForSummoner(summoner.SummonerId, region);
        }

        
        /// /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public static async Task<List<LeagueDto>> RetrievesLeaguesData(
            this ISummoner summoner,
            RegionEnum? region = null)
        {
            return await LeagueService.Instance.RetrievesLeaguesDataForSummoner(summoner.SummonerId, region);
        }
    }
}
