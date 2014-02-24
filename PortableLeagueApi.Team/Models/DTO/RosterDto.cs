using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class RosterDto
    {
        [JsonProperty("memberList")]
        internal TeamMemberInfoDto[] MemberList { get; set; }

        [JsonProperty("ownerId")]
        internal int OwnerId { get; set; }
    }
}