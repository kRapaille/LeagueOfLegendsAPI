using Newtonsoft.Json;

namespace PortableLeagueApi.Stats.Models.DTO
{
    internal class PlayerStatsSummaryListDto
    {
        [JsonProperty("playerStatSummaries")]
        internal PlayerStatsSummaryDto[] PlayerStatSummaries { get; set; }
        
        [JsonProperty("summonerId")]
        internal long SummonerId { get; set; }
    }

    internal class PlayerStatsSummaryDto
    {
        [JsonProperty("playerStatSummaryType")]
        internal string PlayerStatSummaryType { get; set; }

        [JsonProperty("aggregatedStats")]
        internal AggregatedStatsDto AggregatedStats { get; set; }

        [JsonProperty("losses")]
        internal int Losses { get; set; }

        [JsonProperty("modifyDate")]
        internal long ModifyDate { get; set; }

        [JsonProperty("wins")]
        internal int Wins { get; set; }
    }
}