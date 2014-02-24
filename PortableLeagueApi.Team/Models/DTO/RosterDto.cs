using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    public class RosterDto
    {
        [JsonProperty("memberList")]
        public TeamMemberInfoDto[] MemberList { get; set; }

        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }
    }
}