using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO
{
    public class LevelTipDto
    {
        [JsonProperty("effect")]
        public string[] Effect { get; set; }

        [JsonProperty("label")]
        public string[] Label { get; set; }
    }
}
