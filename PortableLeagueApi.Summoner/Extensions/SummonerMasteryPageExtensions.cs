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
    public static class SummonerMasteryPageExtensions
    {
        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<IEnumerable<IMasteryPage>> GetMasteryPagesAsync(
            IApiModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            if (leagueModel == null) throw new ArgumentNullException("leagueModel");

            var summonerService = new SummonerService(leagueModel.ApiConfiguration);
            return await summonerService.GetMasteryPagesBySummonerIdAsync(summonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IMasteryPage>> GetMasteryPagesAsync(
            this IHasSummonerId summoner,
            RegionEnum? region = null)
        {
            return await GetMasteryPagesAsync(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IMasteryPage>> GetMasteryPagesAsync(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await GetMasteryPagesAsync(roster, roster.OwnerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPagesAsync(
            IApiModel leagueModel,
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            if (leagueModel == null) throw new ArgumentNullException("leagueModel");

            var summonerService = new SummonerService(leagueModel.ApiConfiguration);
            return await summonerService.GetMasteryPagesBySummonerIdAsync(summonerIds, region);
        }
        
        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPagesAsync(
            this IEnumerable<IHasSummonerId> summoners,
            RegionEnum? region = null)
        {
            if (summoners == null) throw new ArgumentNullException("summoners");

            var result = new Dictionary<long, IEnumerable<IMasteryPage>>();

            var enumerable = summoners as IList<IHasSummonerId> ?? summoners.ToList();
            if(enumerable.Any())
                result = await GetMasteryPagesAsync(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPagesAsync(
            this IEnumerable<IRoster> rosters,
            RegionEnum? region = null)
        {
            if (rosters == null) throw new ArgumentNullException("rosters");

            var result = new Dictionary<long, IEnumerable<IMasteryPage>>();

            var enumerable = rosters as IList<IRoster> ?? rosters.ToList();
            if (enumerable.Any())
                result = await GetMasteryPagesAsync(enumerable.First(), enumerable.Select(x => x.OwnerId), region);

            return result;
        }
    }
}
