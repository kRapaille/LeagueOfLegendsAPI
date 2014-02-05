using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.Static.Rune
{
    public class RuneListDto
    {
        [JsonProperty("basic")]
        public BasicRuneDataDto Basic { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, RuneDto> Data { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class BasicRuneDataDto {}

    public class RuneDto
    {
        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public ImageDto Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plaintext")]
        public object Plaintext { get; set; }

        [JsonProperty("rune")]
        public RuneTypeDto Rune { get; set; }

        [JsonProperty("stats")]
        public RuneStatsDto Stats { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}
