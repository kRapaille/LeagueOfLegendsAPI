using System.Collections.Generic;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface IRoster
    {
        IList<ITeamMemberInfo> MemberList { get; set; }
        int OwnerId { get; set; }
    }
}