using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Summoner
{
    public class MasteryPagesRoot
    {
        [JsonProperty("pages")]
        public MasteryPage[] Pages { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class MasteryPage
    {
        [JsonProperty("talents")]
        public Talent[] Talents { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("current")]
        public bool Current { get; set; }
    }

    public class Talent
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
