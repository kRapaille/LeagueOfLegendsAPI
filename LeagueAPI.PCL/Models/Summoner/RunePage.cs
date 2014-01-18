using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Summoner
{
    public class RunePageRoot
    {
        /// <summary>
        /// Set of rune pages associated with the summoner.
        /// </summary>
        [JsonProperty("pages")]
        public RunePage[] Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class RunePage
    {
        /// <summary>
        /// Rune page ID.
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// List of rune slots associated with the rune page.
        /// </summary>
        [JsonProperty("slots")]
        public Slot[] Slots { get; set; }

        /// <summary>
        /// Rune page name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the page is the current page.
        /// </summary>
        [JsonProperty("current")]
        public bool Current { get; set; }
    }

    public class Slot
    {
        /// <summary>
        /// Rune slot ID.
        /// </summary>
        [JsonProperty("runeSlotId")]
        public int RuneSlotId { get; set; }

        /// <summary>
        /// Rune associated with the rune slot.
        /// </summary>
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
