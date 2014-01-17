using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static
{
    public class ProfileIconRoot
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("data")]
        public Dictionary<int, ProfileIcon> Data { get; set; }
    }

    public class ProfileIcon
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }
    }
}
