using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class TeamStatDetailDto
    {
        [JsonProperty("averageGamesPlayed")]
        internal int AverageGamesPlayed { get; set; }

        [JsonProperty("fullId")]
        internal string FullId { get; set; }

        [JsonProperty("losses")]
        internal int Losses { get; set; }

        [JsonProperty("teamStatType")]
        internal string TeamStatType { get; set; }
        
        [JsonProperty("wins")]
        internal int Wins { get; set; }
    }
}