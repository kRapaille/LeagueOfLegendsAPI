using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.Summoner
{
    public class RuneDto
    {

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }
    }
}