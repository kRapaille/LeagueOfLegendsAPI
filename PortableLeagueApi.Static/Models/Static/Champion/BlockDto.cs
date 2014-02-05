using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.Static.Champion
{
    public class BlockDto
    {
        [JsonProperty("items")]
        public BlockItemDto[] Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
