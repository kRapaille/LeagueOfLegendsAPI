using Newtonsoft.Json;
using PortableLeagueApi.Core.Helpers;

namespace PortableLeagueApi.Static.Models.Static.SummonerSpell
{
    public class SummonerSpellVarsDto
    {
        [JsonProperty("coeff")]
        [JsonConverter(typeof(CoeffArrayJsonConverter))]
        public float[] Coeff { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}