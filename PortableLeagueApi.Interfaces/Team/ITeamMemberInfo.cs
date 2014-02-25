using System;
using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface ITeamMemberInfo : IHasSummonerId
    {
        DateTime InviteDate { get; set; }
        DateTime JoinDate { get; set; }
        string Status { get; set; }
    }
}