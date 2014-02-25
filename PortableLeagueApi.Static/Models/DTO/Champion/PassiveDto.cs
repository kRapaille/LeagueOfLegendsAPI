using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Champion
{
    public class PassiveDto
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public ImageDto Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
