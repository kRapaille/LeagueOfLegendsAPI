using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static.Item
{
    public class ItemRuneDto
    {
        [JsonProperty("isRune")]
        public bool IsRune { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
