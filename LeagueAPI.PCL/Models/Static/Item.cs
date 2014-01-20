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

        [JsonProperty("groups")]
        public Group[] Groups { get; set; }

        [JsonProperty("tree")]
        public ItemTree[] Tree { get; set; }
    }

    public class ItemTree
    {
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class Group
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        public string MaxGroupOwnable { get; set; }
    }


    public class Item
    {
        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("hideFromAll")]
        public bool HideFromAll { get; set; }

        [JsonProperty("consumed")]
        public bool Consumed { get; set; }

        [JsonProperty("consumeOnFull")]
        public bool ConsumeOnFull { get; set; }

        [JsonProperty("inStore")]
        public bool InStore { get; set; }

        [JsonProperty("stacks")]
        public float Stacks { get; set; }

        [JsonProperty("specialRecipe")]
        public float SpecialRecipe { get; set; }

        [JsonProperty("requiredChampion")]
        public string RequiredChampion { get; set; }

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

        [JsonProperty("from")]
        public string[] From { get; set; }

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

        [JsonProperty("maps")]
        public Dictionary<string, bool> Maps { get; set; }
    }
}
