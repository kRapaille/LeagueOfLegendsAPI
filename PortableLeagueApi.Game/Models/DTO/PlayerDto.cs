using Newtonsoft.Json;

namespace PortableLeagueApi.Game.Models.DTO
{
    internal class PlayerDto
    {
        [JsonProperty("championId")]
        internal int ChampionId { get; set; }

        [JsonProperty("teamId")]
        internal int TeamId { get; set; }

        [JsonProperty("summonerId")]
        internal long SummonerId { get; set; }
    }
}