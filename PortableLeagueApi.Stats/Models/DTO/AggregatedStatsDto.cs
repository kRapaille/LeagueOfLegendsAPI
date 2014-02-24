using Newtonsoft.Json;

namespace PortableLeagueApi.Stats.Models.DTO
{
    internal class AggregatedStatsDto
    {
        [JsonProperty("averageAssists")]
        internal int AverageAssists { get; set; }

        [JsonProperty("averageChampionsKilled")]
        internal int AverageChampionsKilled { get; set; }

        [JsonProperty("averageCombatPlayerScore")]
        internal int AverageCombatPlayerScore { get; set; }

        [JsonProperty("averageNodeCapture")]
        internal int AverageNodeCapture { get; set; }

        [JsonProperty("averageNodeCaptureAssist")]
        internal int AverageNodeCaptureAssist { get; set; }

        [JsonProperty("averageNodeNeutralize")]
        internal int AverageNodeNeutralize { get; set; }

        [JsonProperty("averageNodeNeutralizeAssist")]
        internal int AverageNodeNeutralizeAssist { get; set; }

        [JsonProperty("averageNumDeaths")]
        internal int AverageNumDeaths { get; set; }

        [JsonProperty("averageObjectivePlayerScore")]
        internal int AverageObjectivePlayerScore { get; set; }

        [JsonProperty("averageTeamObjective")]
        internal int AverageTeamObjective { get; set; }

        [JsonProperty("averageTotalPlayerScore")]
        internal int AverageTotalPlayerScore { get; set; }

        [JsonProperty("botGamesPlayed")]
        internal int BotGamesPlayed { get; set; }

        [JsonProperty("killingSpree")]
        internal int KillingSpree { get; set; }

        [JsonProperty("maxAssists")]
        internal int MaxAssists { get; set; }

        [JsonProperty("maxChampionsKilled")]
        internal int MaxChampionsKilled { get; set; }

        [JsonProperty("maxCombatPlayerScore")]
        internal int MaxCombatPlayerScore { get; set; }

        [JsonProperty("maxLargestCriticalStrike")]
        internal int MaxLargestCriticalStrike { get; set; }

        [JsonProperty("maxLargestKillingSpree")]
        internal int MaxLargestKillingSpree { get; set; }

        [JsonProperty("maxNodeCapture")]
        internal int MaxNodeCapture { get; set; }

        [JsonProperty("maxNodeCaptureAssist")]
        internal int MaxNodeCaptureAssist { get; set; }

        [JsonProperty("maxNodeNeutralize")]
        internal int MaxNodeNeutralize { get; set; }

        [JsonProperty("maxNodeNeutralizeAssist")]
        internal int MaxNodeNeutralizeAssist { get; set; }

        [JsonProperty("maxNumDeaths")]
        internal int MaxNumDeaths { get; set; }

        [JsonProperty("maxObjectivePlayerScore")]
        internal int MaxObjectivePlayerScore { get; set; }

        [JsonProperty("maxTeamObjective")]
        internal int MaxTeamObjective { get; set; }

        [JsonProperty("maxTimePlayed")]
        internal int MaxTimePlayed { get; set; }

        [JsonProperty("maxTimeSpentLiving")]
        internal int MaxTimeSpentLiving { get; set; }

        [JsonProperty("maxTotalPlayerScore")]
        internal int MaxTotalPlayerScore { get; set; }

        [JsonProperty("mostChampionKillsPerSession")]
        internal int MostChampionKillsPerSession { get; set; }

        [JsonProperty("mostSpellsCast")]
        internal int MostSpellsCast { get; set; }

        [JsonProperty("normalGamesPlayed")]
        internal int NormalGamesPlayed { get; set; }

        [JsonProperty("rankedPremadeGamesPlayed")]
        internal int RankedPremadeGamesPlayed { get; set; }

        [JsonProperty("rankedSoloGamesPlayed")]
        internal int RankedSoloGamesPlayed { get; set; }

        [JsonProperty("totalAssists")]
        internal int TotalAssists { get; set; }

        [JsonProperty("totalChampionKills")]
        internal int TotalChampionKills { get; set; }

        [JsonProperty("totalDamageDealt")]
        internal int TotalDamageDealt { get; set; }

        [JsonProperty("totalDamageTaken")]
        internal int TotalDamageTaken { get; set; }

        [JsonProperty("totalDeathsPerSession")]
        internal int TotalDeathsPerSession { get; set; }

        [JsonProperty("totalDoubleKills")]
        internal int TotalDoubleKills { get; set; }

        [JsonProperty("totalFirstBlood")]
        internal int TotalFirstBlood { get; set; }

        [JsonProperty("totalGoldEarned")]
        internal int TotalGoldEarned { get; set; }

        [JsonProperty("totalHeal")]
        internal int TotalHeal { get; set; }

        [JsonProperty("totalMagicDamageDealt")]
        internal int TotalMagicDamageDealt { get; set; }

        [JsonProperty("totalMinionKills")]
        internal int TotalMinionKills { get; set; }

        [JsonProperty("totalNeutralMinionsKilled")]
        internal int TotalNeutralMinionsKilled { get; set; }

        [JsonProperty("totalNodeCapture")]
        internal int TotalNodeCapture { get; set; }

        [JsonProperty("totalNodeNeutralize")]
        internal int TotalNodeNeutralize { get; set; }

        [JsonProperty("totalPentaKills")]
        internal int TotalPentaKills { get; set; }

        [JsonProperty("totalPhysicalDamageDealt")]
        internal int TotalPhysicalDamageDealt { get; set; }

        [JsonProperty("totalQuadraKills")]
        internal int TotalQuadraKills { get; set; }

        [JsonProperty("totalSessionsLost")]
        internal int TotalSessionsLost { get; set; }

        [JsonProperty("totalSessionsPlayed")]
        internal int TotalSessionsPlayed { get; set; }

        [JsonProperty("totalSessionsWon")]
        internal int TotalSessionsWon { get; set; }

        [JsonProperty("totalTripleKills")]
        internal int TotalTripleKills { get; set; }

        [JsonProperty("totalTurretsKilled")]
        internal int TotalTurretsKilled { get; set; }

        [JsonProperty("totalUnrealKills")]
        internal int TotalUnrealKills { get; set; }
    }
}
