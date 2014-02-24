using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IAggregatedStats : ILeagueModel
    {
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageAssists { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageChampionsKilled { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageCombatPlayerScore { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageNodeCapture { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageNodeCaptureAssist { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageNodeNeutralize { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageNodeNeutralizeAssist { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageNumDeaths { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageObjectivePlayerScore { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageTeamObjective { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int AverageTotalPlayerScore { get; set; }
        int BotGamesPlayed { get; set; }
        int KillingSpree { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int MaxAssists { get; set; }
        int MaxChampionsKilled { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int MaxCombatPlayerScore { get; set; }
        int MaxLargestCriticalStrike { get; set; }
        int MaxLargestKillingSpree { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int MaxNodeCapture { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int MaxNodeCaptureAssist { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int MaxNodeNeutralize { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int MaxNodeNeutralizeAssist { get; set; }
        /// <summary>
        /// Only returned for ranked statistics.
        /// </summary>
        int MaxNumDeaths { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int MaxObjectivePlayerScore { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int MaxTeamObjective { get; set; }
        int MaxTimePlayed { get; set; }
        int MaxTimeSpentLiving { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int MaxTotalPlayerScore { get; set; }
        int MostChampionKillsPerSession { get; set; }
        int MostSpellsCast { get; set; }
        int NormalGamesPlayed { get; set; }
        int RankedPremadeGamesPlayed { get; set; }
        int RankedSoloGamesPlayed { get; set; }
        int TotalAssists { get; set; }
        int TotalChampionKills { get; set; }
        int TotalDamageDealt { get; set; }
        int TotalDamageTaken { get; set; }
        /// <summary>
        /// Only returned for ranked statistics.
        /// </summary>
        int TotalDeathsPerSession { get; set; }
        int TotalDoubleKills { get; set; }
        int TotalFirstBlood { get; set; }
        int TotalGoldEarned { get; set; }
        int TotalHeal { get; set; }
        int TotalMagicDamageDealt { get; set; }
        int TotalMinionKills { get; set; }
        int TotalNeutralMinionsKilled { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int TotalNodeCapture { get; set; }
        /// <summary>
        /// Dominion only.
        /// </summary>
        int TotalNodeNeutralize { get; set; }
        int TotalPentaKills { get; set; }
        int TotalPhysicalDamageDealt { get; set; }
        int TotalQuadraKills { get; set; }
        int TotalSessionsLost { get; set; }
        int TotalSessionsPlayed { get; set; }
        int TotalSessionsWon { get; set; }
        int TotalTripleKills { get; set; }
        int TotalTurretsKilled { get; set; }
        int TotalUnrealKills { get; set; }
    }
}