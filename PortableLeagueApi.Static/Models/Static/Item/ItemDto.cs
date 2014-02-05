using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.Static.Item
{
    public class ItemListDto
    {
        [JsonProperty("basic")]
        public BasicDataDto Basic { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, ItemDto> Data { get; set; }

        [JsonProperty("groups")]
        public GroupDto[] Groups { get; set; }

        [JsonProperty("tree")]
        public ItemTreeDto[] Tree { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class ItemDto
    {
        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("gold")]
        public GoldDto Gold { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("image")]
        public ImageDto Image { get; set; }

        [JsonProperty("into")]
        public string[] Into { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, object> Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}
