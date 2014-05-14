using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.League
{
    public interface IMiniSeries : IApiModel
    {
        /// <summary>
        /// Number of current losses in the mini series.
        /// </summary>
        int Losses { get; set; }
        /// <summary>
        /// String showing the current, sequential mini series progress where 'W' represents a win, 'L' represents a loss, and 'N' represents a game that hasn't been played yet.
        /// </summary>
        string Progress { get; set; }
        /// <summary>
        /// Number of wins required for promotion.
        /// </summary>
        int Target { get; set; }
        /// <summary>
        /// Number of current wins in the mini series.
        /// </summary>
        int Wins { get; set; }
    }
}