using System;
using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface ITeam : IApiModel
    {
        DateTime CreateDate { get; set; }
        string FullId { get; set; }
        DateTime LastGameDate { get; set; }
        DateTime LastJoinDate { get; set; }
        DateTime LastJoinedRankedTeamQueueDate { get; set; }
        IList<IMatchHistorySummary> MatchHistory { get; set; }
        IMessageOfDay MessageOfDay { get; set; }
        DateTime ModifyDate { get; set; }
        string Name { get; set; }
        IRoster Roster { get; set; }
        DateTime SecondLastJoinDate { get; set; }
        string Status { get; set; }
        string Tag { get; set; }
        ITeamStatSummary TeamStatSummary { get; set; }
        DateTime ThirdLastJoinDate { get; set; }
    }
}