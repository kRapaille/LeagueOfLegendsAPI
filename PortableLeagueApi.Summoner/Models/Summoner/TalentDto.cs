using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.Summoner
{
    public class TalentDto
    {
        /// <summary>
        /// Talent id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

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