using Newtonsoft.Json;

namespace PortableLeagueApi.Stats.Models.DTO
{
    internal class ChampionStatsDto
    {
        [JsonProperty("id")]
        internal int ChampionId { get; set; }

        [JsonProperty("stats")]
        internal AggregatedStatsDto Stats { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }
    }
}