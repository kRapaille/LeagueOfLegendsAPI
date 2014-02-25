using System;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface IMatchHistorySummary : IApiModel
    {
        int Assists { get; set; }
        DateTime Date { get; set; }
        int Deaths { get; set; }
        int GameId { get; set; }
        string GameMode { get; set; }
        bool Invalid { get; set; }
        int Kills { get; set; }
        MapEnum Map { get; set; }
        int OpposingTeamKills { get; set; }
        string OpposingTeamName { get; set; }
        bool Win { get; set; }
    }
}