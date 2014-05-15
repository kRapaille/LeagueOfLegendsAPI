using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.League
{
    public interface ILeagueEntry : IApiModel
    {
        /// <summary>
        /// The league division of the participant.
        /// </summary>
        string Division { get; set; }
        /// <summary>
        /// Specifies if the participant is fresh blood.
        /// </summary>
        bool IsFreshBlood { get; set; }
        /// <summary>
        /// Specifies if the participant is on a hot streak.
        /// </summary>
        bool IsHotStreak { get; set; }
        /// <summary>
        /// Specifies if the participant is inactive.
        /// </summary>
        bool IsInactive { get; set; }
        /// <summary>
        /// Specifies if the participant is a veteran.
        /// </summary>
        bool IsVeteran { get; set; }
        /// <summary>
        /// The league points of the participant.
        /// </summary>
        int LeaguePoints { get; set; }
        /// <summary>
        /// Mini series data for the participant. Only present if the participant is currently in a mini series.
        /// </summary>
        IMiniSeries MiniSeries { get; set; }
        /// <summary>
        /// The ID of the participant (i.e., summoner or team) represented by this entry.
        /// </summary>
        string PlayerOrTeamId { get; set; }
        /// <summary>
        /// The name of the the participant (i.e., summoner or team) represented by this entry.
        /// </summary>
        string PlayerOrTeamName { get; set; }
        /// <summary>
        /// The number of wins for the participant.
        /// </summary>
        int Wins { get; set; }
    }
}