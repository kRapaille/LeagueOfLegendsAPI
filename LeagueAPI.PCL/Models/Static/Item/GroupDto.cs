using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static.Item
{
    public class GroupDto
    {
        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }
    }
}
