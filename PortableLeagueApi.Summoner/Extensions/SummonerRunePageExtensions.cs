using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Summoner.Services;

namespace PortableLeagueApi.Summoner.Extensions
{
    public static class SummonerRunePageExtensions
    {
        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<IEnumerable<IRunePage>> GetRunePagesAsync(
            IApiModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            if (leagueModel == null) throw new ArgumentNullException("leagueModel");

            var summonerService = new SummonerService(leagueModel.ApiConfiguration);
            return await summonerService.GetRunePagesBySummonerIdAsync(summonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IRunePage>> GetRunePagesAsync(
            this IHasSummonerId summoner,
            RegionEnum? region = null)
        {
            return await GetRunePagesAsync(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IRunePage>> GetRunePagesAsync(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await GetRunePagesAsync(roster, roster.OwnerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePagesAsync(
            IApiModel leagueModel,
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            if (leagueModel == null) throw new ArgumentNullException("leagueModel");

            var summonerService = new SummonerService(leagueModel.ApiConfiguration);
            return await summonerService.GetRunePagesBySummonerIdAsync(summonerIds, region);
        }
        
        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePagesAsync(
            this IEnumerable<IHasSummonerId> summoners,
            RegionEnum? region = null)
        {
            if (summoners == null) throw new ArgumentNullException("summoners");

            var result = new Dictionary<long, IEnumerable<IRunePage>>();

            var enumerable = summoners as IList<IHasSummonerId> ?? summoners.ToList();
            if(enumerable.Any())
                result = await GetRunePagesAsync(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePagesAsync(
            this IEnumerable<IRoster> rosters,
            RegionEnum? region = null)
        {
            if (rosters == null) throw new ArgumentNullException("rosters");

            var result = new Dictionary<long, IEnumerable<IRunePage>>();

            var enumerable = rosters as IList<IRoster> ?? rosters.ToList();
            if (enumerable.Any())
                result = await GetRunePagesAsync(enumerable.First(), enumerable.Select(x => x.OwnerId), region);

            return result;
        }
    }
}
