using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Summoner
{
    public class TalentDto
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