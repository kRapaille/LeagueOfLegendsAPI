using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.Static.Item
{
    public class GroupDto
    {
        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }
    }
}
