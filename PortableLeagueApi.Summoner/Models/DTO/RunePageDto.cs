using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    public class RunePagesDto : ISummoner
    {
        /// <summary>
        /// Set of rune pages associated with the summoner.
        /// </summary>
        [JsonProperty("pages")]
        public RunePageDto[] Pages { get; set; }

        /// <summary>
        /// Summoner Id.
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }

    public class RunePageDto
    {
        /// <summary>
        /// Rune page Id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

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
