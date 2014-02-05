using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.Team
{
    public class TeamMemberInfoDto
    {
        [JsonProperty("inviteDate")]
        public long InviteDate { get; set; }

        [JsonProperty("joinDate")]
        public long JoinDate { get; set; }

        [JsonProperty("playerId")]
        public int PlayerId { get; set; }
        
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}