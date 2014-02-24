using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Interfaces.Team;

namespace PortableLeagueApi.Interfaces.League
{
    public static class RetrieveLeaguesDataExtensions
    {
        private static async Task<IEnumerable<ILeague>> RetrievesLeaguesData(
            ILeagueModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.League.RetrievesLeaguesDataForSummonerAsync(summonerId, region);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrievesLeaguesData(
            this ISummoner summoner,
            RegionEnum? region = null)
        {
            return await RetrievesLeaguesData(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrievesLeaguesData(
            this ITeamMemberInfo teamMemberInfo,
            RegionEnum? region = null)
        {
            return await RetrievesLeaguesData(teamMemberInfo, teamMemberInfo.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrievesLeaguesData(
            this IRankedStats rankedStats,
            RegionEnum? region = null)
        {
            return await RetrievesLeaguesData(rankedStats, rankedStats.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrievesLeaguesData(
            this IPlayer player,
            RegionEnum? region = null)
        {
            return await RetrievesLeaguesData(player, player.SummonerId, region);
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
