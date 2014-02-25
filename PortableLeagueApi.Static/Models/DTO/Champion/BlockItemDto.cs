using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Champion
{
    internal class BlockItemDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
