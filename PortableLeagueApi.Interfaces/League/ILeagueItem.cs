using System;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.League
{
    public interface ILeagueItem : IApiModel
    {
        bool IsFreshBlood { get; set; }
        bool IsHotStreak { get; set; }
        bool IsInactive { get; set; }
        bool IsVeteran { get; set; }
        DateTime LastPlayed { get; set; }
        /// <summary>
        /// This name is an internal place-holder name only. Display and localization of names in the client are handled client-side.
        /// </summary>
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