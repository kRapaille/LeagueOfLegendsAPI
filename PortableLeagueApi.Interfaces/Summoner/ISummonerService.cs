using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface ISummonerService
    {
        /// <summary>
        /// Get mastery pages
        /// </summary>
        Task<IEnumerable<IMasteryPage>> GetMasteryPagesBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null);

        /// <summary>
        /// Get mastery pages
        /// </summary>
        Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPagesBySummonerIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null);

        /// <summary>
        /// Get rune pages
        /// </summary>
        Task<IEnumerable<IRunePage>> GetRunePagesBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null);

        /// <summary>
        /// Get rune pages
        /// </summary>
        Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePagesBySummonerIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null);

        Task<ISummoner> GetSummonerByNameAsync(
            string name,
            RegionEnum? region = null);

        Task<ISummoner> GetSummonerByIdAsync(
            long summonerId,
            RegionEnum? region = null);

        Task<IEnumerable<ISummoner>> GetSummonerByIdAsync(
            IEnumerable<long> summonersId,
            RegionEnum? region = null);

        Task<Dictionary<long, string>> GetSummonerNamesByIdAsync(
            long summonerId,
            RegionEnum? region = null);

        Task<Dictionary<long, string>> GetSummonerNamesByIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null);
    }
}