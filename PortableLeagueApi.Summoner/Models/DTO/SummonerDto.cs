using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class SummonerDto
    {
        [JsonProperty("id")]
        internal long SummonerId { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("profileIconId")]
        internal int ProfileIconId { get; set; }

        [JsonProperty("revisionDate")]
        internal long RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        internal long SummonerLevel { get; set; }
    }
}
