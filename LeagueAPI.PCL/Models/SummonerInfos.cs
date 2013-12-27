using Newtonsoft.Json;

namespace LeagueAPI.PCL.Models
{
    public class SummonerInfosRoot
    {
        [JsonProperty("summoners")]
        public SummonerInfos[] Summoners { get; set; }
    }

    public class SummonerInfos
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
