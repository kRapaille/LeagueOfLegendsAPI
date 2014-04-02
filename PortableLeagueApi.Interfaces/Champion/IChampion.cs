using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Champion
{
    public interface IChampion: IHasChampionId
    {
        /// <summary>
        /// Bot Match Made enabled flag (for Co-op vs. AI games).
        /// </summary>
        bool IsBotMatchMadeEnabled { get; set; }
        /// <summary>
        /// Bot enabled flag (for custom games).
        /// </summary>
        bool IsBotEnabledForCustomGames { get; set; }
        /// <summary>
        /// Ranked play enabled flag.
        /// </summary>
        bool IsAvailableInRanked { get; set; }
        /// <summary>
        /// Indicates if the champion is active.
        /// </summary>
        bool IsActive { get; set; }
        /// <summary>
        /// Indicates if the champion is free to play. Free to play champions are rotated periodically.
        /// </summary>
        bool IsFreeToPlay { get; set; }
    }
}