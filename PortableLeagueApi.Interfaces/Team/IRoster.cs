using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface IRoster : ILeagueModel
    {
        IList<ITeamMemberInfo> MemberList { get; set; }
        long OwnerId { get; set; }
    }
}