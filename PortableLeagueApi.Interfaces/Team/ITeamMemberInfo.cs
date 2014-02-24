using System;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface ITeamMemberInfo
    {
        DateTime InviteDate { get; set; }
        DateTime JoinDate { get; set; }
        long SummonerId { get; set; }
        string Status { get; set; }
    }
}