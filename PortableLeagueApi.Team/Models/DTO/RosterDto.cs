using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class RosterDto
    {
        [JsonProperty("memberList")]
        public TeamMemberInfoDto[] MemberList { get; set; }

        [JsonProperty("ownerId")]
        public long OwnerId { get; set; }
    }
}