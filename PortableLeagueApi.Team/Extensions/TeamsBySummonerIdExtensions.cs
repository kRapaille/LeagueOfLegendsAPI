using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Services;

namespace PortableLeagueApi.Team.Extensions
{
    public static class TeamsBySummonerIdExtensions
    {
        /// <summary>
        /// Retrieves teams
        /// </summary>
        private static async Task<IEnumerable<ITeam>> GetTeamsBySummonerIdAsync(
            IApiModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            if (leagueModel == null) throw new ArgumentNullException("leagueModel");

            var teamService = new TeamService(leagueModel.ApiConfiguration);
            return await teamService.GetTeamsBySummonerIdAsync(summonerId, region);
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public static async Task<IEnumerable<ITeam>> GetTeamsBySummonerIdAsync(
            this IHasSummonerId summoner,
            RegionEnum? region = null)
        {
            return await GetTeamsBySummonerIdAsync(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Retrieves teams
        /// </summary>
        public static async Task<IEnumerable<ITeam>> GetTeamsBySummonerIdAsync(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await GetTeamsBySummonerIdAsync(roster, roster.OwnerId, region);
        }
    }
}