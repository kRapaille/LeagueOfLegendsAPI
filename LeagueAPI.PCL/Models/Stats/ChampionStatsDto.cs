using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Stats
{
    public class ChampionStatsDto
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
        public AggregatedStatsDto Stats { get; set; }

        /// <summary>
        /// Champion name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}