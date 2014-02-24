using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    public class TalentDto : IMastery
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