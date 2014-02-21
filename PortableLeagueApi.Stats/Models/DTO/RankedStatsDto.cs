using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Stats.Models.DTO
{
    public class RankedStatsDto : ISummoner
    {
        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        /// <summary>
        /// List of aggregated stats summarized by champion.
        /// </summary>
        [JsonProperty("champions")]
        public ChampionStatsDto[] Champions { get; set; }

        /// <summary>
        /// Summoner Id.
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
