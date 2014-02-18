using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Summoner.Models.Summoner
{
    public class RuneDto : IRune
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