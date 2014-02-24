using System;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface ITeamMemberInfo : ILeagueModel
    {
        DateTime InviteDate { get; set; }
        DateTime JoinDate { get; set; }
        long SummonerId { get; set; }
        string Status { get; set; }
    }
}