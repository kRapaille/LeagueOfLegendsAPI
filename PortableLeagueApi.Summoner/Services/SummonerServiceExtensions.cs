using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Summoner.Models.Summoner;

namespace PortableLeagueApi.Summoner.Services
{
    public static class SummonerServiceExtensions
    {
        ///// <summary>
        ///// Get mastery pages
        ///// </summary>
        //public static async Task<IEnumerable<MasteryPageDto>> GetMasteryPages(
        //    this ISummoner summoner,
        //    SummonerService summonerService,
        //    RegionEnum? region = null)
        //{
        //    return await summonerService.GetMasteryPagesBySummonerIdAsync(summoner.SummonerId, region);
        //}

        ///// <summary>
        ///// Get mastery pages
        ///// </summary>
        //public static async Task<Dictionary<long, IEnumerable<MasteryPageDto>>> GetMasteryPages(
        //    this IEnumerable<ISummoner> summoners,
        //    SummonerService summonerService,
        //    RegionEnum? region = null)
        //{
        //    return await summonerService.GetMasteryPagesBySummonerIdAsync(summoners.Select(x => x.SummonerId), region);
        //}

        ///// <summary>
        ///// Get rune pages
        ///// </summary>
        //public static async Task<IEnumerable<RunePageDto>> GetRunePages(
        //    this ISummoner summoner,
        //    SummonerService summonerService,
        //    RegionEnum? region = null)
        //{
        //    return await summonerService.GetRunePagesBySummonerIdAsync(summoner.SummonerId, region);
        //}

        ///// <summary>
        ///// Get rune pages
        ///// </summary>
        //public static async Task<Dictionary<long, IEnumerable<RunePageDto>>> GetRunePages(
        //    this IEnumerable<ISummoner> summoners,
        //    SummonerService summonerService,
        //    RegionEnum? region = null)
        //{
        //    return await summonerService.GetRunePagesBySummonerIdAsync(summoners.Select(x => x.SummonerId), region);
        //}
    }
}
