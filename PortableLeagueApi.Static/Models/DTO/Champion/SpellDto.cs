using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Champion
{
    internal class SpellDto
    {
        [JsonProperty("altimages")]
        public IList<ImageDto> AltImages { get; set; }

        [JsonProperty("cooldown")]
        public IList<double> Cooldown { get; set; }

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
        public IList<IList<int>> Effect { get; set; }

        [JsonProperty("effectBurn")]
        public string[] EffectBurn { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

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

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        [JsonProperty("vars")]
        public IList<SpellVarsDto> Vars { get; set; }
    }
}
