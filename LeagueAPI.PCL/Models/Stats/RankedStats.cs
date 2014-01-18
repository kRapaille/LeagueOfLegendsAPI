using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Stats
{
    public class RankedStats
    {
        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        /// <summary>
        /// List of aggregated stats summarized by champion.
        /// </summary>
        [JsonProperty("champions")]
        public RankedStatsChampion[] Champions { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class RankedStatsChampion
    {
        /// <summary>
        /// Champion id.
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// Aggregated stats associated with the champion.
        /// </summary>
        [JsonProperty("stats")]
        public AggregatedStats Stats { get; set; }

        /// <summary>
        /// Champion name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
