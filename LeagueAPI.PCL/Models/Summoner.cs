using Newtonsoft.Json;

namespace PortableLeagueAPI.Models
{
    public class Summoner
    {
        [JsonProperty("revisionDateStr")]
        public string RevisionDateStr { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
