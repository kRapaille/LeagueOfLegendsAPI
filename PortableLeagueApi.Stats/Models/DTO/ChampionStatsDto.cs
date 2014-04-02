using Newtonsoft.Json;

namespace PortableLeagueApi.Stats.Models.DTO
{
    internal class ChampionStatsDto
    {
        [JsonProperty("id")]
        public int ChampionId { get; set; }

        [JsonProperty("stats")]
        public AggregatedStatsDto Stats { get; set; }
    }
}