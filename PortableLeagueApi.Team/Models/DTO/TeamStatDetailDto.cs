using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class TeamStatDetailDto
    {
        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }
        
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}