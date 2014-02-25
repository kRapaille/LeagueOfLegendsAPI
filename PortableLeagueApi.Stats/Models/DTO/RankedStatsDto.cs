using Newtonsoft.Json;

namespace PortableLeagueApi.Stats.Models.DTO
{
    internal class RankedStatsDto
    {
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        [JsonProperty("champions")]
        public ChampionStatsDto[] Champions { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
