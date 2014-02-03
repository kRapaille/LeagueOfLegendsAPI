
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static.Champion
{
    public class BlockItemDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
