using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class TeamMemberInfoDto
    {
        [JsonProperty("inviteDate")]
        public long InviteDate { get; set; }

        [JsonProperty("joinDate")]
        public long JoinDate { get; set; }

        [JsonProperty("playerId")]
        public long SummonerId { get; set; }
        
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}