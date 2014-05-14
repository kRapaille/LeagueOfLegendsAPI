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
        Task<IEnumerable<ILeague>> RetrievesLeaguesEntryDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        Task<IDictionary<string, IEnumerable<ILeague>>> RetrievesLeaguesEntryDataForSummonerAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        Task<IEnumerable<ILeague>> RetrievesLeaguesDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams.
        /// </summary>
        Task<IDictionary<string, IEnumerable<ILeague>>> RetrievesLeaguesDataForSummonerAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves leagues data for team
        /// </summary>
        Task<IEnumerable<ILeague>> RetrievesLeaguesEntryDataForTeamAsync(
            string teamId,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves leagues data for team
        /// </summary>
        Task<IDictionary<string, IEnumerable<ILeague>>> RetrievesLeaguesEntryDataForTeamAsync(
            IEnumerable<string> teamIds,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves leagues data for team
        /// </summary>
        Task<IEnumerable<ILeague>> RetrievesLeaguesDataForTeamAsync(
            string teamId,
            RegionEnum? region = null);

        /// <summary>
        /// Retrieves leagues data for team
        /// </summary>
        Task<IDictionary<string, IEnumerable<ILeague>>> RetrievesLeaguesDataForTeamAsync(
            IEnumerable<string> teamIds,
            RegionEnum? region = null);
    }
}