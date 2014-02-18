using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Summoner.Models.Summoner;

namespace PortableLeagueApi.Summoner.Services
{
    public class SummonerService : BaseService
    {
        private SummonerService() : base(VersionEnum.V1Rev3, "summoner") { }

        private static SummonerService _instance;

        public static SummonerService Instance
        {
            get { return _instance ?? (_instance = new SummonerService()); }
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public async Task<IEnumerable<MasteryPageDto>> GetMasteryPagesBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetMasteryPagesBySummonerId(new[] {summonerId}, region);

            return result[summonerId];
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public async Task<Dictionary<long, IEnumerable<MasteryPageDto>>> GetMasteryPagesBySummonerId(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/masteries",
                string.Join(",", summonerIds));

            var masteryPagesRoot = await GetResponse<Dictionary<long, MasteryPagesDto>>(region, url);

            return masteryPagesRoot.ToDictionary(x => x.Key, x => x.Value.Pages.AsEnumerable());
        }

        /// <summary>
        /// Get rune pages
        /// </summary>
        public async Task<IEnumerable<RunePageDto>> GetRunePagesBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetRunePagesBySummonerId(new[] {summonerId}, region);

            return result[summonerId];
        }

        /// <summary>
        /// Get rune pages
        /// </summary>
        public async Task<Dictionary<long, IEnumerable<RunePageDto>>> GetRunePagesBySummonerId(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/runes",
                string.Join(",", summonerIds));

            var runePageRoot = await GetResponse<Dictionary<long, RunePagesDto>>(region, url);

            return runePageRoot.ToDictionary(x => x.Key, x => x.Value.Pages.AsEnumerable());
        }

        public async Task<SummonerDto> GetSummonerByName(
            string name,
            RegionEnum? region = null)
        {
            var url = string.Format("by-name/{0}",
                name);

            var result = await GetResponse<Dictionary<string, SummonerDto>>(region, url);

            return result.Select(x => x.Value).FirstOrDefault();
        }

        public async Task<SummonerDto> GetSummonerById(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetSummonerById(new[] { summonerId }, region);

            return result.FirstOrDefault();
        }
        public async Task<IEnumerable<SummonerDto>> GetSummonerById(
           IEnumerable<long> summonersId,
           RegionEnum? region = null)
        {
            var url = string.Format("{0}",
                string.Join(",", summonersId));

            var result = await GetResponse<Dictionary<string, SummonerDto>>(region, url);

            return result.Select(x => x.Value);
        }
        public async Task<Dictionary<long, string>> GetSummonerNamesById(
            long summonerId,
            RegionEnum? region = null)
        {
            return await GetSummonerNamesById(new[] { summonerId }, region);
        }

        public async Task<Dictionary<long, string>> GetSummonerNamesById(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/name",
                string.Join(",", summonerIds));

            var summonersInfo = await GetResponse<Dictionary<long, string>>(region, url);

            return summonersInfo;
        }
    }
}
