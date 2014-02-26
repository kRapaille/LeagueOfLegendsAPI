using Newtonsoft.Json;

namespace PortableLeagueApi.Stats.Models.DTO
{
    internal class PlayerStatsSummaryListDto
    {
        [JsonProperty("playerStatSummaries")]
        public PlayerStatsSummaryDto[] PlayerStatSummaries { get; set; }
        
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }

    internal class PlayerStatsSummaryDto
    {
        [JsonProperty("playerStatSummaryType")]
        public string PlayerStatSummaryType { get; set; }

        [JsonProperty("aggregatedStats")]
        public AggregatedStatsDto AggregatedStats { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}