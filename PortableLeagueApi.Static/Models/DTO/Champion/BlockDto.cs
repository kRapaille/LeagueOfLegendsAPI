using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Champion
{
    internal class BlockDto
    {
        [JsonProperty("items")]
        public BlockItemDto[] Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
