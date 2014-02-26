using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface IRoster : IApiModel
    {
        IList<ITeamMemberInfo> MemberList { get; set; }
        long OwnerId { get; set; }
    }
}