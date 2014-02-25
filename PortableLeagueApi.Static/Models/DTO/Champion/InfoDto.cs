using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Champion
{
    public class InfoDto
    {
        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty("magic")]
        public int Magic { get; set; }
    }
}
