using Newtonsoft.Json;

namespace PortableLeagueApi.Game.Models.DTO
{
    internal class PlayerDto
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}