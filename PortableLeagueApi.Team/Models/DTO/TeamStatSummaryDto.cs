using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class TeamStatSummaryDto
    {
        [JsonProperty("fullId")]
        internal string FullId { get; set; }

        [JsonProperty("teamStatDetails")]
        internal TeamStatDetailDto[] TeamStatDetails { get; set; }
    }
}