using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Champion
{
    public interface IChampion: IApiModel
    {
        /// <summary>
        /// Champion Id.
        /// </summary>
        int ChampionId { get; set; }
        /// <summary>
        /// Champion name.
        /// </summary>
        string Name { get; set; }
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
        /// <summary>
        /// Champion magic rank.
        /// </summary>
        int MagicRank { get; set; }
        /// <summary>
        /// Champion defense rank.
        /// </summary>
        int DefenseRank { get; set; }
        /// <summary>
        /// Champion attack rank.
        /// </summary>
        int AttackRank { get; set; }
        /// <summary>
        /// Champion difficulty rank.
        /// </summary>
        int DifficultyRank { get; set; }
    }
}