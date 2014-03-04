using System;
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
        private static async Task<IEnumerable<ILeague>> RetrievesLeaguesDataAsync(
            IApiModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            if (leagueModel == null) throw new ArgumentNullException("leagueModel");

            var leagueService = new LeagueService(leagueModel.ApiConfiguration);
            return await leagueService.RetrievesLeaguesDataForSummonerAsync(summonerId, region);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrievesLeaguesDataAsync(
            this IHasSummonerId summoner,
            RegionEnum? region = null)
        {
            return await RetrievesLeaguesDataAsync(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrievesLeaguesDataAsync(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await RetrievesLeaguesDataAsync(roster, roster.OwnerId, region);
        }
    }
}
