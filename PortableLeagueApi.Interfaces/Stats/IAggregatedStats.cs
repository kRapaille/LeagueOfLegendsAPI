namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IAggregatedStats
    {
        int AverageAssists { get; set; }
        int AverageChampionsKilled { get; set; }
        int AverageCombatPlayerScore { get; set; }
        int AverageNodeCapture { get; set; }
        int AverageNodeCaptureAssist { get; set; }
        int AverageNodeNeutralize { get; set; }
        int AverageNodeNeutralizeAssist { get; set; }
        int AverageNumDeaths { get; set; }
        int AverageObjectivePlayerScore { get; set; }
        int AverageTeamObjective { get; set; }
        int AverageTotalPlayerScore { get; set; }
        int BotGamesPlayed { get; set; }
        int KillingSpree { get; set; }
        int MaxAssists { get; set; }
        int MaxChampionsKilled { get; set; }
        int MaxCombatPlayerScore { get; set; }
        int MaxLargestCriticalStrike { get; set; }
        int MaxLargestKillingSpree { get; set; }
        int MaxNodeCapture { get; set; }
        int MaxNodeCaptureAssist { get; set; }
        int MaxNodeNeutralize { get; set; }
        int MaxNodeNeutralizeAssist { get; set; }
        int MaxNumDeaths { get; set; }
        int MaxObjectivePlayerScore { get; set; }
        int MaxTeamObjective { get; set; }
        int MaxTimePlayed { get; set; }
        int MaxTimeSpentLiving { get; set; }
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
        int TotalDeathsPerSession { get; set; }
        int TotalDoubleKills { get; set; }
        int TotalFirstBlood { get; set; }
        int TotalGoldEarned { get; set; }
        int TotalHeal { get; set; }
        int TotalMagicDamageDealt { get; set; }
        int TotalMinionKills { get; set; }
        int TotalNeutralMinionsKilled { get; set; }
        int TotalNodeCapture { get; set; }
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