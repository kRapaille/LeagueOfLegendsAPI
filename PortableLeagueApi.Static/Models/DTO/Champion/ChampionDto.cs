using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Champion
{
    internal class ChampionListDto
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("keys")]
        public Dictionary<string, string> Keys { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, ChampionDto> Data { get; set; }
    }

    internal class ChampionDto
    {
        [JsonProperty("allytips")]
        public string[] AllyTips { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("enemytips")]
        public string[] Enemytips { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image")]
        public ImageDto Image { get; set; }

        [JsonProperty("info")]
        public InfoDto Info { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("lore")]
        public string Lore { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("partype")]
        public string Partype { get; set; }

        [JsonProperty("passive")]
        public PassiveDto Passive { get; set; }

        [JsonProperty("recommended")]
        public RecommendedDto[] Recommended { get; set; }

        [JsonProperty("skins")]
        public SkinDto[] Skins { get; set; }

        [JsonProperty("spells")]
        public SpellDto[] Spells { get; set; }

        [JsonProperty("stats")]
        public StatsDto Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
