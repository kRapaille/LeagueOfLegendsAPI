using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static
{
    public class LanguageRoot
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, string> Data { get; set; }

        [JsonProperty("tree")]
        public Tree Tree { get; set; }
    }

    
    public class Tree
    {
        [JsonProperty("searchKeyIgnore")]
        public string SearchKeyIgnore { get; set; }

        [JsonProperty("searchKeyRemap")]
        public object[] SearchKeyRemap { get; set; }
    }
}
