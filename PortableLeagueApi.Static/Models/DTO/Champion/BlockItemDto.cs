using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Champion
{
    public class BlockItemDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
