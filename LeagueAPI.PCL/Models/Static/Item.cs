using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static
{
    public class ItemRootObject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("basic")]
        public Basic Basic { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, Item> Data { get; set; }
    }

    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("into")]
        public string[] Into { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("gold")]
        public Gold Gold { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}
