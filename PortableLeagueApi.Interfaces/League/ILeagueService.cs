using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.League
{
    public interface ILeagueService
    {
        /// <summary>
        /// Retrieves challenger tier leagues.
        /// </summary>
        Task<ILeague> RetrievesChallengerTierLeaguesAsync(
            LeagueTypeEnum leagueType,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        Task<IEnumerable<ILeagueItem>> RetrievesLeaguesEntryDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        Task<IEnumerable<ILeague>> RetrievesLeaguesDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null);
    }
}