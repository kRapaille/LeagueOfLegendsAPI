using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Summoner;

namespace PortableLeagueAPI.Services
{
    public class SummonerService : BaseService
    {
        private SummonerService()
        {
            CompatibleVersions = new[]
            {
                // TODO : Manage model versioning
                //VersionEnum.V1Rev1,
                //VersionEnum.V1Rev2,
                VersionEnum.V1Rev3
            };
        }

        private static SummonerService _instance;

        internal static SummonerService Instance
        {
            get { return _instance ?? (_instance = new SummonerService()); }
        }

        public async Task<Dictionary<long, IEnumerable<MasteryPage>>> GetMasteryPagesBySummonerId(
            long summonerId,
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            return await GetMasteryPagesBySummonerId(new[] {summonerId}, region, version);
        }

        public async Task<Dictionary<long, IEnumerable<MasteryPage>>> GetMasteryPagesBySummonerId(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/{2}/masteries",
                GetRegionAsString(region),
                GetVersionAsString(version),
                string.Join(",", summonerIds));

            var masteryPagesRoot = await GetResponse<Dictionary<long, MasteryPagesRoot>>(url);

            return masteryPagesRoot.ToDictionary(x => x.Key, x => x.Value.Pages.AsEnumerable());
        }

        public async Task<Dictionary<long, IEnumerable<RunePage>>> GetRunePagesBySummonerId(
            long summonerId,
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            return await GetRunePagesBySummonerId(new[] {summonerId}, region, version);
        }

        public async Task<Dictionary<long, IEnumerable<RunePage>>> GetRunePagesBySummonerId(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/{2}/runes",
                GetRegionAsString(region),
                GetVersionAsString(version),
                string.Join(",", summonerIds));

            var runePageRoot = await GetResponse<Dictionary<long, RunePageRoot>>(url);

            return runePageRoot.ToDictionary(x => x.Key, x => x.Value.Pages.AsEnumerable());
        }

        public async Task<Summoner> GetSummonerByName(
            string name, 
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/by-name/{2}",
                GetRegionAsString(region),
                GetVersionAsString(version),
                name);

            return await GetResponse<Summoner>(url);
        }

        public async Task<Summoner> GetSummonerById(
            long summonerId,
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/{2}",
                GetRegionAsString(region),
                GetVersionAsString(version),
                summonerId);

            return await GetResponse<Summoner>(url);
        }

        public async Task<Dictionary<long, string>> GetSummonerNamesById(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/{2}/name", 
                GetRegionAsString(region), 
                GetVersionAsString(version),
                string.Join(",", summonerIds));

            var summonersInfo = await GetResponse<Dictionary<long, string>>(url);

            return summonersInfo;
        }

        public async Task<Dictionary<long, string>> GetSummonerNamesById(
            long summonerId,
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            return await GetSummonerNamesById(new[] {summonerId}, region, version);
        }
    }
}
