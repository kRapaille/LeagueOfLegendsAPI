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
    public static class RetrieveLeaguesEntryDataExtensions
    {
        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        private static async Task<IEnumerable<ILeagueItem>> RetrieveLeaguesEntryData(
            IApiModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            var leagueService = new LeagueService(leagueModel.ApiConfiguration);
            return await leagueService.RetrieveLeaguesEntryDataForSummonerAsync(summonerId, region);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public static async Task<IEnumerable<ILeagueItem>> RetrieveLeaguesEntryData(
            this IHasSummonerId summoner,
            RegionEnum? region = null)
        {
            return await RetrieveLeaguesEntryData(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public static async Task<IEnumerable<ILeagueItem>> RetrieveLeaguesEntryData(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await RetrieveLeaguesEntryData(roster, roster.OwnerId, region);
        }
    }
}
