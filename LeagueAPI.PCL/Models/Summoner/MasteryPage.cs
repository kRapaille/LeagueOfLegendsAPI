using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Summoner
{
    public class MasteryPagesRoot
    {
        /// <summary>
        /// List of mastery pages associated with the summoner.
        /// </summary>
        [JsonProperty("pages")]
        public MasteryPage[] Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class MasteryPage
    {
        /// <summary>
        /// Mastery page ID.
        /// </summary>
        [JsonProperty("id")]
        public long ID { get; set; }

        /// <summary>
        /// List of mastery page talents associated with the mastery page.
        /// </summary>
        [JsonProperty("talents")]
        public Talent[] Talents { get; set; }

        /// <summary>
        /// Mastery page name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the mastery page is the current mastery page.
        /// </summary>
        [JsonProperty("current")]
        public bool Current { get; set; }
    }

    public class Talent
    {
        /// <summary>
        /// Talent id.
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// Talent name.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }

        /// <summary>
        /// Talent rank.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
