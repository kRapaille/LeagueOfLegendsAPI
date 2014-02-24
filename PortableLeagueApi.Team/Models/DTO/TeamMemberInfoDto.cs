using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Team.Models.DTO
{
    public class TeamMemberInfoDto : ISummoner
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