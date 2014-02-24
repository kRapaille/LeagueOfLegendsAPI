using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Stats.Models;
using PortableLeagueApi.Stats.Models.DTO;

namespace PortableLeagueApi.Stats.Services
{
    public class StatsService : BaseService, IStatsService
    {
        public StatsService(
            ILeagueAPI source)
            : base(source, VersionEnum.V1Rev2, "stats")
        {
            RankedStats.CreateMap(AutoMapperService, source);
            PlayerStatsSummary.CreateMap(AutoMapperService, source);
        }

        /// <summary>
        /// Get player stats summaries. One summary is returned per queue type.
        /// </summary>
        public async Task<IEnumerable<IPlayerStatsSummary>> GetPlayerStatsSummariesBySummonerIdAsync(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/summary",
                summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            return await GetResponseAsync<PlayerStatsSummaryListDto, IEnumerable<IPlayerStatsSummary>>(region, url);
        }

        /// <summary>
        /// Get ranked stats. Includes statistics for Twisted Treeline and Summoner's Rift.
        /// </summary>
        public async Task<IRankedStats> GetRankedStatsSummariesBySummonerIdAsync(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/ranked",
                summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            return await GetResponseAsync<RankedStatsDto, IRankedStats>(region, url);
        }
    }
}
