using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Item
{
    internal class GroupDto
    {
        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
