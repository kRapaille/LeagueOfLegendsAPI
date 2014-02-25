using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO
{
    public class ImageDto
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("sprite")]
        public string Sprite { get; set; }

        [JsonProperty("h")]
        public int Height { get; set; }

        [JsonProperty("w")]
        public int Width { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
