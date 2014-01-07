using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueAPI.Models;
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
                VersionEnum.V1Rev1,
                VersionEnum.V1Rev2
            };
        }

        private static SummonerService _instance;

        internal static SummonerService Instance
        {
            get { return _instance ?? (_instance = new SummonerService()); }
        }

        public async Task<IEnumerable<MasteryPage>> GetMasteryPagesBySummonerId(
            long summonerId,
            RegionEnum? region = null,
            VersionEnum? verion = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/{2}/masteries",
                GetRegion(region),
                GetVersionAsString(verion), 
                summonerId);

            var masteryPagesRoot = await GetResponse<MasteryPagesRoot>(url);

            return masteryPagesRoot.Pages.AsEnumerable();
        }

        public async Task<IEnumerable<RunePage>> GetRunePagesBySummonerId(
            long summonerId,
            RegionEnum? region = null,
            VersionEnum? verion = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/{2}/runes",
                GetRegion(region),
                GetVersionAsString(verion), 
                summonerId);

            var runePageRoot = await GetResponse<RunePageRoot>(url);

            return runePageRoot.Pages.AsEnumerable();
        }

        public async Task<Summoner> GetSummonerByName(
            string name, 
            RegionEnum? region = null,
            VersionEnum? verion = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/by-name/{2}",
                GetRegion(region),
                GetVersionAsString(verion),
                name);

            return await GetResponse<Summoner>(url);
        }

        public async Task<Summoner> GetSummonerById(
            long summonerId,
            RegionEnum? region = null,
            VersionEnum? verion = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/{2}",
                GetRegion(region),
                GetVersionAsString(verion),
                summonerId);

            return await GetResponse<Summoner>(url);
        }

        public async Task<IEnumerable<SummonerInfos>> GetSummonerNamesByIds(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null,
            VersionEnum? verion = null)
        {
            var url = string.Format("lol/{0}/{1}/summoner/{2}/name", 
                GetRegion(region), 
                GetVersionAsString(verion),
                string.Join(",", summonerIds));

            var summonerInfosRoot = await GetResponse<SummonerInfosRoot>(url);

            return summonerInfosRoot.Summoners.AsEnumerable();
        }
    }
}
