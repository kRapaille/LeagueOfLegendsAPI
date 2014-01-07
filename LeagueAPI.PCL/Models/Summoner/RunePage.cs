using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Summoner
{
    public class RunePageRoot
    {
        [JsonProperty("pages")]
        public RunePage[] Pages { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class RunePage
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("slots")]
        public Slot[] Slots { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("current")]
        public bool Current { get; set; }
    }

    public class Slot
    {

        [JsonProperty("runeSlotId")]
        public int RuneSlotId { get; set; }

        [JsonProperty("rune")]
        public Rune Rune { get; set; }
    }

    public class Rune
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
