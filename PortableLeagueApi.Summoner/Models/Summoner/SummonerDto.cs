using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Summoner.Models.Summoner
{
    public class SummonerDto : ISummoner
    {
        /// <summary>
        /// Summoner Id.
        /// </summary>
        [JsonProperty("id")]
        public long SummonerId { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Id of the summoner icon associated with the summoner.
        /// </summary>
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }
    }
}
