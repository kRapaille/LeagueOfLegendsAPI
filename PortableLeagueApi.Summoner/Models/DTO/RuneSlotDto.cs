using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class RuneSlotDto
    {
        [JsonProperty("runeSlotId")]
        public int RuneSlotId { get; set; }

        [JsonProperty("rune")]
        public RuneDto Rune { get; set; }
    }
}