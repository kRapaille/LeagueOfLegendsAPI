using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static.Rune
{
    public class RuneTypeDto
    {
        [JsonProperty("isrune")]
        public bool Isrune { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
