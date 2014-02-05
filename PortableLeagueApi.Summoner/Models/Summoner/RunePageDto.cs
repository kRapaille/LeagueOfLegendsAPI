using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.Summoner
{
    public class RunePagesDto
    {
        /// <summary>
        /// Set of rune pages associated with the summoner.
        /// </summary>
        [JsonProperty("pages")]
        public RunePageDto[] Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class RunePageDto
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
        public RuneSlotDto[] Slots { get; set; }

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
}
