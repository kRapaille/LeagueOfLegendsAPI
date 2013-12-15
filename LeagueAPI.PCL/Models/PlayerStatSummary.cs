using Newtonsoft.Json;

namespace LeagueAPI.PCL.Models
{
    public class PlayerStatSummaryRoot
    {
        [JsonProperty("playerStatSummaries")]
        public PlayerStatSummary[] PlayerStatSummaries { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class PlayerStatSummary
    {
        [JsonProperty("playerStatSummaryType")]
        public string PlayerStatSummaryType { get; set; }

        [JsonProperty("aggregatedStats")]
        public Aggregatedstat[] AggregatedStats { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        [JsonProperty("modifyDateStr")]
        public long ModifyDateStr { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }

    public class Aggregatedstat
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
