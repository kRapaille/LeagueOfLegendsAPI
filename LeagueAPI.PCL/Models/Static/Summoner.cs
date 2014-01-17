using System.Collections.Generic;
using Newtonsoft.Json;
using PortableLeagueAPI.Helpers;

namespace PortableLeagueAPI.Models.Static
{
    public class SummonerRootobject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, Summoner> Data { get; set; }
    }

    public class Summoner
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("maxrank")]
        public int Maxrank { get; set; }

        [JsonProperty("cooldown")]
        public int[] Cooldown { get; set; }

        [JsonProperty("cooldownBurn")]
        public string CooldownBurn { get; set; }

        [JsonProperty("cost")]
        public int[] Cost { get; set; }

        [JsonProperty("costBurn")]
        public string CostBurn { get; set; }

        [JsonProperty("effect")]
        public object[] Effect { get; set; }

        [JsonProperty("effectBurn")]
        public object[] EffectBurn { get; set; }

        [JsonProperty("vars")]
        public Var[] Vars { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }

        [JsonProperty("modes")]
        public string[] Modes { get; set; }

        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("range")]
        [JsonConverter(typeof(RangeJsonConverter))]
        public int Range { get; set; }

        [JsonProperty("rangeBurn")]
        public string RangeBurn { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }
    public class Var
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("coeff")]
        [JsonConverter(typeof(CoeffArrayJsonConverter))]
        public float[] Coeff { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

}
