using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class RuneSlotDto
    {
        [JsonProperty("runeSlotId")]
        internal int RuneSlotId { get; set; }

        [JsonProperty("rune")]
        internal RuneDto Rune { get; set; }
    }
}