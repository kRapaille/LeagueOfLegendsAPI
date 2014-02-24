using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Services
{
    public class SummonerService : BaseService, ISummonerService
    {
        public SummonerService(
            ILeagueAPI source)
            : base(source, VersionEnum.V1Rev3, "summoner")
        {
            MasteryPage.CreateMap(AutoMapperService, source);
            RunePage.CreateMap(AutoMapperService, source);
            Models.Summoner.CreateMap(AutoMapperService, source);
        }
        
        /// <summary>
        /// Get mastery pages
        /// </summary>
        public async Task<IEnumerable<IMasteryPage>> GetMasteryPagesBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetMasteryPagesBySummonerIdAsync(new[] {summonerId}, region);

            return result[summonerId];
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public async Task<Dictionary<long, IEnumerable<IMasteryPage>>> GetMasteryPagesBySummonerIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/masteries",
                string.Join(",", summonerIds));

            return await GetResponseAsync<Dictionary<long, MasteryPagesDto>, Dictionary<long, IEnumerable<IMasteryPage>>>(region, url);
        }

        /// <summary>
        /// Get rune pages
        /// </summary>
        public async Task<IEnumerable<IRunePage>> GetRunePagesBySummonerIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetRunePagesBySummonerIdAsync(new[] {summonerId}, region);

            return result[summonerId];
        }

        /// <summary>
        /// Get rune pages
        /// </summary>
        public async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePagesBySummonerIdAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/runes",
                string.Join(",", summonerIds));

            return await GetResponseAsync<Dictionary<long, RunePagesDto>, Dictionary<long, IEnumerable<IRunePage>>>(region, url);
        }

        public async Task<ISummoner> GetSummonerByNameAsync(
            string name,
            RegionEnum? region = null)
        {
            var url = string.Format("by-name/{0}",
                name);

            var result = await GetResponseAsync<Dictionary<string, SummonerDto>, Dictionary<string, ISummoner>>(region, url);

            return result.Select(x => x.Value).FirstOrDefault();
        }

        public async Task<ISummoner> GetSummonerByIdAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await GetSummonerByIdAsync(new[] { summonerId }, region);

            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<ISummoner>> GetSummonerByIdAsync(
           IEnumerable<long> summonersId,
           RegionEnum? region = null)
        {
            var url = string.Format("{0}",
                string.Join(",", summonersId));

            var result = await GetResponseAsync<Dictionary<string, SummonerDto>, Dictionary<string, ISummoner>>(region, url);

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
