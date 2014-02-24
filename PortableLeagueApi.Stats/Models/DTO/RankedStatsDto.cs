using Newtonsoft.Json;

namespace PortableLeagueApi.Stats.Models.DTO
{
    internal class RankedStatsDto
    {
        [JsonProperty("modifyDate")]
        internal long ModifyDate { get; set; }

        [JsonProperty("champions")]
        internal ChampionStatsDto[] Champions { get; set; }

        [JsonProperty("summonerId")]
        internal long SummonerId { get; set; }
    }
}
