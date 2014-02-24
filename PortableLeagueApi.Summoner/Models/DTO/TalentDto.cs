using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class TalentDto
    {
        [JsonProperty("id")]
        internal int Id { get; set; }

        [JsonProperty("rank")]
        internal int Rank { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }
    }
}