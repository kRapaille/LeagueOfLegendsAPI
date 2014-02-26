using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.League.Services;

namespace PortableLeagueApi.League.Extensions
{
    public static class RetrieveLeaguesDataExtensions
    {
        private static async Task<IEnumerable<ILeague>> RetrievesLeaguesData(
            IApiModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            var leagueService = new LeagueService(leagueModel.ApiConfiguration);
            return await leagueService.RetrievesLeaguesDataForSummonerAsync(summonerId, region);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrievesLeaguesData(
            this IHasSummonerId summoner,
            RegionEnum? region = null)
        {
            return await RetrievesLeaguesData(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrievesLeaguesData(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await RetrievesLeaguesData(roster, roster.OwnerId, region);
        }
    }
}
