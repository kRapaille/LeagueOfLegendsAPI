using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    public class MasteryPagesDto : ISummoner
    {
        /// <summary>
        /// List of mastery pages associated with the summoner.
        /// </summary>
        [JsonProperty("pages")]
        public MasteryPageDto[] Pages { get; set; }

        /// <summary>
        /// Summoner Id.
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }

    public class MasteryPageDto
    {
        /// <summary>
        /// Mastery page Id.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// List of mastery page talents associated with the mastery page.
        /// </summary>
        [JsonProperty("talents")]
        public TalentDto[] Talents { get; set; }

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
}
