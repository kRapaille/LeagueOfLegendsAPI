using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Summoner;

namespace PortableLeagueAPI.Services
{
    public class SummonerService : BaseService
    {
        private SummonerService() : base(VersionEnum.V1Rev3) { }

        private static SummonerService _instance;

        internal static SummonerService Instance
        {
            get { return _instance ?? (_instance = new SummonerService()); }
        }

        public async Task<Dictionary<long, IEnumerable<MasteryPage>>> GetMasteryPagesBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            return await GetMasteryPagesBySummonerId(new[] {summonerId}, region);
        }

        public async Task<Dictionary<long, IEnumerable<MasteryPage>>> GetMasteryPagesBySummonerId(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("summoner/{0}/masteries",
                string.Join(",", summonerIds));

            var masteryPagesRoot = await GetResponse<Dictionary<long, MasteryPagesRoot>>(region, url);

            return masteryPagesRoot.ToDictionary(x => x.Key, x => x.Value.Pages.AsEnumerable());
        }

        public async Task<Dictionary<long, IEnumerable<RunePage>>> GetRunePagesBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            return await GetRunePagesBySummonerId(new[] {summonerId}, region);
        }

        public async Task<Dictionary<long, IEnumerable<RunePage>>> GetRunePagesBySummonerId(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("summoner/{0}/runes",
                string.Join(",", summonerIds));

            var runePageRoot = await GetResponse<Dictionary<long, RunePageRoot>>(region, url);

            return runePageRoot.ToDictionary(x => x.Key, x => x.Value.Pages.AsEnumerable());
        }

        public async Task<Summoner> GetSummonerByName(
            string name,
            RegionEnum? region = null)
        {
            var url = string.Format("summoner/by-name/{0}",
                name);

            var result = await GetResponse<Dictionary<string, Summoner>>(region, url);

            return result.Select(x => x.Value).FirstOrDefault();
        }

        public async Task<Summoner> GetSummonerById(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetSummonerById(new[] { summonerId }, region);

            return result.FirstOrDefault();
        }
        public async Task<IEnumerable<Summoner>> GetSummonerById(
           IEnumerable<long> summonersId,
           RegionEnum? region = null)
        {
            var url = string.Format("summoner/{0}",
                string.Join(",", summonersId));

            var result = await GetResponse<Dictionary<string, Summoner>>(region, url);

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
            var url = string.Format("summoner/{0}/name",
                string.Join(",", summonerIds));

            var summonersInfo = await GetResponse<Dictionary<long, string>>(region, url);

            return summonersInfo;
        }

    }
}
