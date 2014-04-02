using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class RuneSlotDto
    {
        [JsonProperty("runeSlotId")]
        public int RuneSlotId { get; set; }

        [JsonProperty("runeId")]
        public int RuneId { get; set; }
    }
}