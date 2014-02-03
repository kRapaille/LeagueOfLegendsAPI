using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static.Item
{
    public class BasicDataDto
    {
        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("consumeOnFull")]
        public bool ConsumeOnFull { get; set; }

        [JsonProperty("consumed")]
        public bool Consumed { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("from")]
        public string[] From { get; set; }

        [JsonProperty("gold")]
        public GoldDto Gold { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("hideFromAll")]
        public bool HideFromAll { get; set; }

        [JsonProperty("inStore")]
        public bool InStore { get; set; }

        [JsonProperty("into")]
        public string[] Into { get; set; }

        [JsonProperty("maps")]
        public Dictionary<string, bool> Maps { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("requiredChampion")]
        public string RequiredChampion { get; set; }

        [JsonProperty("rune")]
        public ItemRuneDto Rune { get; set; }

        [JsonProperty("specialRecipe")]
        public int SpecialRecipe { get; set; }

        [JsonProperty("stacks")]
        public int Stacks { get; set; }

        [JsonProperty("stats")]
        public ItemStatsDto Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}
