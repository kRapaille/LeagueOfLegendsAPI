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
    public static class SummonerRunePageExtensions
    {
        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<IEnumerable<IRunePage>> GetRunePages(
            ILeagueModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.Summoner.GetRunePagesBySummonerIdAsync(summonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IRunePage>> GetRunePages(
            this ISummoner summoner,
            RegionEnum? region = null)
        {
            return await GetRunePages(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IRunePage>> GetRunePages(
            this ITeamMemberInfo teamMemberInfo,
            RegionEnum? region = null)
        {
            return await GetRunePages(teamMemberInfo, teamMemberInfo.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IRunePage>> GetRunePages(
            this IRankedStats rankedStats,
            RegionEnum? region = null)
        {
            return await GetRunePages(rankedStats, rankedStats.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IRunePage>> GetRunePages(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await GetRunePages(roster, roster.OwnerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IRunePage>> GetRunePages(
            this IPlayer player,
            RegionEnum? region = null)
        {
            return await GetRunePages(player, player.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePages(
            ILeagueModel leagueModel,
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.Summoner.GetRunePagesBySummonerIdAsync(summonerIds, region);
        }
        
        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePages(
            this IEnumerable<ISummoner> summoners,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IRunePage>>();

            var enumerable = summoners as IList<ISummoner> ?? summoners.ToList();
            if(enumerable.Any())
                result = await GetRunePages(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePages(
            this IEnumerable<ITeamMemberInfo> teamMemberInfos,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IRunePage>>();

            var enumerable = teamMemberInfos as IList<ITeamMemberInfo> ?? teamMemberInfos.ToList();
            if (enumerable.Any())
                result = await GetRunePages(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePages(
            this IEnumerable<IRankedStats> rankedStats,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IRunePage>>();

            var enumerable = rankedStats as IList<IRankedStats> ?? rankedStats.ToList();
            if (enumerable.Any())
                result = await GetRunePages(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePages(
            this IEnumerable<IPlayer> players,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IRunePage>>();

            var enumerable = players as IList<IPlayer> ?? players.ToList();
            if (enumerable.Any())
                result = await GetRunePages(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePages(
            this IEnumerable<IRoster> rosters,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IRunePage>>();

            var enumerable = rosters as IList<IRoster> ?? rosters.ToList();
            if (enumerable.Any())
                result = await GetRunePages(enumerable.First(), enumerable.Select(x => x.OwnerId), region);

            return result;
        }
    }
}
