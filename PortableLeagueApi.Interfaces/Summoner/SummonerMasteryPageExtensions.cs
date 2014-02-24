using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Interfaces.Team;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public static class SummonerMasteryPageExtensions
    {
        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<IEnumerable<IMasteryPage>> GetMasteryPages(
            ILeagueModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.Summoner.GetMasteryPagesBySummonerIdAsync(summonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IMasteryPage>> GetMasteryPages(
            this ISummoner summoner,
            RegionEnum? region = null)
        {
            return await GetMasteryPages(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IMasteryPage>> GetMasteryPages(
            this ITeamMemberInfo teamMemberInfo,
            RegionEnum? region = null)
        {
            return await GetMasteryPages(teamMemberInfo, teamMemberInfo.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IMasteryPage>> GetMasteryPages(
            this IRankedStats rankedStats,
            RegionEnum? region = null)
        {
            return await GetMasteryPages(rankedStats, rankedStats.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IMasteryPage>> GetMasteryPages(
            this IPlayer player,
            RegionEnum? region = null)
        {
            return await GetMasteryPages(player, player.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IMasteryPage>> GetMasteryPages(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await GetMasteryPages(roster, roster.OwnerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPages(
            ILeagueModel leagueModel,
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.Summoner.GetMasteryPagesBySummonerIdAsync(summonerIds, region);
        }
        
        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPages(
            this IEnumerable<ISummoner> summoners,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IMasteryPage>>();

            var enumerable = summoners as IList<ISummoner> ?? summoners.ToList();
            if(enumerable.Any())
                result = await GetMasteryPages(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPages(
            this IEnumerable<ITeamMemberInfo> teamMemberInfos,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IMasteryPage>>();

            var enumerable = teamMemberInfos as IList<ITeamMemberInfo> ?? teamMemberInfos.ToList();
            if (enumerable.Any())
                result = await GetMasteryPages(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPages(
            this IEnumerable<IRankedStats> rankedStats,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IMasteryPage>>();

            var enumerable = rankedStats as IList<IRankedStats> ?? rankedStats.ToList();
            if (enumerable.Any())
                result = await GetMasteryPages(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPages(
            this IEnumerable<IPlayer> players,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IMasteryPage>>();

            var enumerable = players as IList<IPlayer> ?? players.ToList();
            if (enumerable.Any())
                result = await GetMasteryPages(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPages(
            this IEnumerable<IRoster> rosters,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IMasteryPage>>();

            var enumerable = rosters as IList<IRoster> ?? rosters.ToList();
            if (enumerable.Any())
                result = await GetMasteryPages(enumerable.First(), enumerable.Select(x => x.OwnerId), region);

            return result;
        }
    }
}
