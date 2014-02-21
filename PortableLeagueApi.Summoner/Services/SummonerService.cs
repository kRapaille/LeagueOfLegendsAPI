using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Summoner.Models.Summoner;

namespace PortableLeagueApi.Summoner.Services
{
    public class SummonerService : BaseService
    {
        public SummonerService(
            ILeagueAPI source)
            : base(source, VersionEnum.V1Rev3, "summoner")
        { }
        
        /// <summary>
        /// Get mastery pages
        /// </summary>
        public async Task<IEnumerable<MasteryPageDto>> GetMasteryPagesBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetMasteryPagesBySummonerIdAsync(new[] {summonerId}, region);

            return result[summonerId];
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public async Task<Dictionary<long, IEnumerable<MasteryPageDto>>> GetMasteryPagesBySummonerIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/masteries",
                string.Join(",", summonerIds));

            var masteryPagesRoot = await GetResponseAsync<Dictionary<long, MasteryPagesDto>>(region, url);

            return masteryPagesRoot.ToDictionary(x => x.Key, x => x.Value.Pages.AsEnumerable());
        }

        /// <summary>
        /// Get rune pages
        /// </summary>
        public async Task<IEnumerable<RunePageDto>> GetRunePagesBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetRunePagesBySummonerIdAsync(new[] {summonerId}, region);

            return result[summonerId];
        }

        /// <summary>
        /// Get rune pages
        /// </summary>
        public async Task<Dictionary<long, IEnumerable<RunePageDto>>> GetRunePagesBySummonerIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/runes",
                string.Join(",", summonerIds));

            var runePageRoot = await GetResponseAsync<Dictionary<long, RunePagesDto>>(region, url);

            return runePageRoot.ToDictionary(x => x.Key, x => x.Value.Pages.AsEnumerable());
        }

        public async Task<SummonerDto> GetSummonerByNameAsync(
            string name,
            RegionEnum? region = null)
        {
            var url = string.Format("by-name/{0}",
                name);

            var result = await GetResponseAsync<Dictionary<string, SummonerDto>>(region, url);

            return result.Select(x => x.Value).FirstOrDefault();
        }

        public async Task<SummonerDto> GetSummonerByIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetSummonerByIdAsync(new[] { summonerId }, region);

            return result.FirstOrDefault();
        }
        public async Task<IEnumerable<SummonerDto>> GetSummonerByIdAsync(
           IEnumerable<long> summonersId,
           RegionEnum? region = null)
        {
            var url = string.Format("{0}",
                string.Join(",", summonersId));

            var result = await GetResponseAsync<Dictionary<string, SummonerDto>>(region, url);

            return result.Select(x => x.Value);
        }
        public async Task<Dictionary<long, string>> GetSummonerNamesByIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            return await GetSummonerNamesByIdAsync(new[] { summonerId }, region);
        }

        public async Task<Dictionary<long, string>> GetSummonerNamesByIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/name",
                string.Join(",", summonerIds));

            var summonersInfo = await GetResponseAsync<Dictionary<long, string>>(region, url);

            return summonersInfo;
        }
    }
}
