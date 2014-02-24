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
    public static class RetrieveLeaguesEntryDataExtensions
    {
        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        private static async Task<IEnumerable<ILeagueItem>> RetrieveLeaguesEntryData(
            ILeagueModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.League.RetrieveLeaguesEntryDataForSummonerAsync(summonerId, region);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public static async Task<IEnumerable<ILeagueItem>> RetrieveLeaguesEntryData(
            this ISummoner summoner,
            RegionEnum? region = null)
        {
            return await RetrieveLeaguesEntryData(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public static async Task<IEnumerable<ILeagueItem>> RetrieveLeaguesEntryData(
            this ITeamMemberInfo teamMemberInfo,
            RegionEnum? region = null)
        {
            return await RetrieveLeaguesEntryData(teamMemberInfo, teamMemberInfo.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public static async Task<IEnumerable<ILeagueItem>> RetrieveLeaguesEntryData(
            this IRankedStats rankedStats,
            RegionEnum? region = null)
        {
            return await RetrieveLeaguesEntryData(rankedStats, rankedStats.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public static async Task<IEnumerable<ILeagueItem>> RetrieveLeaguesEntryData(
            this IPlayer player,
            RegionEnum? region = null)
        {
            return await RetrieveLeaguesEntryData(player, player.SummonerId, region);
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
