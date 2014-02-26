using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Item
{
    internal class GroupDto
    {
        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
