using System.Collections.Generic;
using Newtonsoft.Json;
using PortableLeagueApi.Core.Helpers;

namespace PortableLeagueApi.Static.Models.DTO.Champion
{
    internal class SpellVarsDto
    {
        [JsonProperty("coeff")]
        [JsonConverter(typeof(CoeffArrayJsonConverter))]
        public IList<float> Coeff { get; set; }

        [JsonProperty("dyn")]
        public string Dyn { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}