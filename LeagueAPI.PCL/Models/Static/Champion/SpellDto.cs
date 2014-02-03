﻿using Newtonsoft.Json;
using PortableLeagueAPI.Models.Static.SummonerSpell;

namespace PortableLeagueAPI.Models.Static.Champion
{
    public class SpellDto
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
        public object[] Effect { get; set; }

        [JsonProperty("effectBurn")]
        public string[] EffectBurn { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("image")]
        public ImageDto Image { get; set; }

        [JsonProperty("leveltip")]
        public LevelTipDto Leveltip { get; set; }

        [JsonProperty("maxrank")]
        public int Maxrank { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("range")]
        public object Range { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("vars")]
        public object[] Vars { get; set; }
    }
}
