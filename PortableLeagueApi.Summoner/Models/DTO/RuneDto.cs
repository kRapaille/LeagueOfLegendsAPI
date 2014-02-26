using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class RuneDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }
    }
}