using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Interfaces.Summoner;

namespace PortableLeagueApi.Interfaces.Team
{
    public static class TeamsBySummonerIdExtensions
    {
        /// <summary>
        /// Retrieves teams
        /// </summary>
        private static async Task<IEnumerable<ITeam>> GetTeamsBySummonerId(
            ILeagueModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            return await leagueModel.Source.Team.GetTeamsBySummonerIdAsync(summonerId, region);
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public static async Task<IEnumerable<ITeam>> GetTeamsBySummonerId(
            this ISummoner summoner,
            RegionEnum? region = null)
        {
            return await GetTeamsBySummonerId(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public static async Task<IEnumerable<ITeam>> GetTeamsBySummonerId(
            this ITeamMemberInfo teamMemberInfo,
            RegionEnum? region = null)
        {
            return await GetTeamsBySummonerId(teamMemberInfo, teamMemberInfo.SummonerId, region);
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public static async Task<IEnumerable<ITeam>> GetTeamsBySummonerId(
            this IRankedStats rankedStats,
            RegionEnum? region = null)
        {
            return await GetTeamsBySummonerId(rankedStats, rankedStats.SummonerId, region);
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public static async Task<IEnumerable<ITeam>> GetTeamsBySummonerId(
            this IPlayer player,
            RegionEnum? region = null)
        {
            return await GetTeamsBySummonerId(player, player.SummonerId, region);
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public static async Task<IEnumerable<ITeam>> GetTeamsBySummonerId(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await GetTeamsBySummonerId(roster, roster.OwnerId, region);
        }
    }
}
