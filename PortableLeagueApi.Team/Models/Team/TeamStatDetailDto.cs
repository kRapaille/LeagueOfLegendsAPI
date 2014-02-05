using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.Team
{
    public class TeamStatDetailDto
    {
        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        [JsonProperty("fullId")]
        public string FullId { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }
        
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}