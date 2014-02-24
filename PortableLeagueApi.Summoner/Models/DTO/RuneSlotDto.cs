using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    public class RuneSlotDto
    {
        /// <summary>
        /// Rune slot Id.
        /// </summary>
        [JsonProperty("runeSlotId")]
        public int RuneSlotId { get; set; }

        /// <summary>
        /// Rune associated with the rune slot.
        /// </summary>
        [JsonProperty("rune")]
        public RuneDto Rune { get; set; }
    }
}