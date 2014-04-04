using System.Collections.Generic;
using Newtonsoft.Json;
using PortableLeagueApi.Core.Helpers;

namespace PortableLeagueApi.Static.Models.DTO.SummonerSpell
{
    internal class SummonerSpellListDto
    {
        [JsonProperty("data")]
        public Dictionary<string, SummonerSpellDto> Data { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    internal class SummonerSpellDto
    {
        [JsonProperty("cooldown")]
        public int[] Cooldown { get; set; }

        [JsonProperty("cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty("cost")]
        public int[] Cost { get; set; }

        [JsonProperty("costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("effect")]
        public IList<IList<float>> Effect { get; set; }

        [JsonProperty("effectBurn")]
        public string[] EffectBurn { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public ImageDto Image { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("leveltip")]
        public LevelTipDto Leveltip { get; set; }
        
        [JsonProperty("maxrank")]
        public int MaxRank { get; set; }

        [JsonProperty("modes")]
        public string[] Modes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("range")]
        [JsonConverter(typeof(RangeJsonConverter))]
        public int Range { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("vars")]
        public SummonerSpellVarsDto[] Vars { get; set; }
    }
}
