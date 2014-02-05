using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.Team
{
    public class TeamStatSummaryDto
    {
        [JsonProperty("fullId")]
        public string FullId { get; set; }

        [JsonProperty("teamStatDetails")]
        public TeamStatDetailDto[] TeamStatDetails { get; set; }
    }
}