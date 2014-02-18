using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Summoner.Models.Summoner;

namespace PortableLeagueApi.Summoner.Services
{
    public static class SummonerServiceExtensions
    {
        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<MasteryPageDto>> GetMasteryPages(
            this ISummoner summoner,
            RegionEnum? region = null)
        {   
            return await SummonerService.Instance.GetMasteryPagesBySummonerId(summoner.Id, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<MasteryPageDto>>> GetMasteryPages(
            this IEnumerable<ISummoner> summoners,
            RegionEnum? region = null)
        {
            return await SummonerService.Instance.GetMasteryPagesBySummonerId(summoners.Select(x => x.Id), region);
        }

        /// <summary>
        /// Get rune pages
        /// </summary>
        public static async Task<IEnumerable<RunePageDto>> GetRunePages(
            this ISummoner summoner,
            RegionEnum? region = null)
        {
            return await SummonerService.Instance.GetRunePagesBySummonerId(summoner.Id, region);
        }

        /// <summary>
        /// Get rune pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<RunePageDto>>> GetRunePages(
            this IEnumerable<ISummoner> summoners,
            RegionEnum? region = null)
        {
            return await SummonerService.Instance.GetRunePagesBySummonerId(summoners.Select(x => x.Id), region);
        }
    }
}
