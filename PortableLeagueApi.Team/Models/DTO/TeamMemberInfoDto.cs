using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class TeamMemberInfoDto
    {
        [JsonProperty("inviteDate")]
        internal long InviteDate { get; set; }

        [JsonProperty("joinDate")]
        internal long JoinDate { get; set; }

        [JsonProperty("playerId")]
        internal long SummonerId { get; set; }
        
        [JsonProperty("status")]
        internal string Status { get; set; }
    }
}