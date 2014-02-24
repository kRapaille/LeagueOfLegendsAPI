using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class RuneDto
    {
        [JsonProperty("id")]
        internal int Id { get; set; }

        [JsonProperty("description")]
        internal string Description { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("tier")]
        internal int Tier { get; set; }
    }
}