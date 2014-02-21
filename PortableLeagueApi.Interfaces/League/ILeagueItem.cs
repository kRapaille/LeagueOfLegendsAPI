using System;

namespace PortableLeagueApi.Interfaces.League
{
    public interface ILeagueItem
    {
        bool IsFreshBlood { get; set; }
        bool IsHotStreak { get; set; }
        bool IsInactive { get; set; }
        bool IsVeteran { get; set; }
        DateTime LastPlayed { get; set; }
        string LeagueName { get; set; }
        int LeaguePoints { get; set; }
        IMiniSeries MiniSeries { get; set; }
        string PlayerOrTeamId { get; set; }
        string PlayerOrTeamName { get; set; }
        string QueueType { get; set; }
        string Rank { get; set; }
        string Tier { get; set; }
        int Wins { get; set; }
    }
}