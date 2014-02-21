using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Stats.Enums;
using PortableLeagueApi.Stats.Models.Stats;

namespace PortableLeagueApi.Stats.Services
{
    public static class StatsServiceExtensions
    {
        ///// <summary>
        ///// Get player stats summaries. One summary is returned per queue type.
        ///// </summary>
        //public static async Task<IEnumerable<PlayerStatsSummaryDto>> GetPlayerStatsSummaries(
        //    this ISummoner summoner,
        //    StatsService statsService,
        //    SeasonEnum? season = null,
        //    RegionEnum? region = null)
        //{
        //    return await statsService.GetPlayerStatsSummariesBySummonerIdAsync(summoner.SummonerId, season, region);
        //}


        ///// <summary>
        ///// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        ///// </summary>
        //public static async Task<RankedStatsDto> GetRankedStatsSummaries(
        //    this ISummoner summoner,
        //    StatsService statsService,
        //    SeasonEnum? season = null,
        //    RegionEnum? region = null)
        //{
        //    return await statsService.GetRankedStatsSummariesBySummonerIdAsync(summoner.SummonerId, season, region);
        //}
    }
}
