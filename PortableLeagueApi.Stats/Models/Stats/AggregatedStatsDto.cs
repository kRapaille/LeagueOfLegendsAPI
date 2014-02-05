using Newtonsoft.Json;

namespace PortableLeagueApi.Stats.Models.Stats
{
    public class AggregatedStatsDto
    {
        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageAssists")]
        public int AverageAssists { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageChampionsKilled")]
        public int AverageChampionsKilled { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageCombatPlayerScore")]
        public int AverageCombatPlayerScore { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageNodeCapture")]
        public int AverageNodeCapture { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageNodeCaptureAssist")]
        public int AverageNodeCaptureAssist { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageNodeNeutralize")]
        public int AverageNodeNeutralize { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageNodeNeutralizeAssist")]
        public int AverageNodeNeutralizeAssist { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageNumDeaths")]
        public int AverageNumDeaths { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageObjectivePlayerScore")]
        public int AverageObjectivePlayerScore { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageTeamObjective")]
        public int AverageTeamObjective { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("averageTotalPlayerScore")]
        public int AverageTotalPlayerScore { get; set; }

        [JsonProperty("botGamesPlayed")]
        public int BotGamesPlayed { get; set; }

        [JsonProperty("killingSpree")]
        public int KillingSpree { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("maxAssists")]
        public int MaxAssists { get; set; }

        [JsonProperty("maxChampionsKilled")]
        public int MaxChampionsKilled { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("maxCombatPlayerScore")]
        public int MaxCombatPlayerScore { get; set; }

        [JsonProperty("maxLargestCriticalStrike")]
        public int MaxLargestCriticalStrike { get; set; }

        [JsonProperty("maxLargestKillingSpree")]
        public int MaxLargestKillingSpree { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("maxNodeCapture")]
        public int MaxNodeCapture { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("maxNodeCaptureAssist")]
        public int MaxNodeCaptureAssist { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("maxNodeNeutralize")]
        public int MaxNodeNeutralize { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("maxNodeNeutralizeAssist")]
        public int MaxNodeNeutralizeAssist { get; set; }

        /// <summary>
        /// Only returned for ranked statistics.
        /// </summary>
        [JsonProperty("maxNumDeaths")]
        public int MaxNumDeaths { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("maxObjectivePlayerScore")]
        public int MaxObjectivePlayerScore { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("maxTeamObjective")]
        public int MaxTeamObjective { get; set; }

        [JsonProperty("maxTimePlayed")]
        public int MaxTimePlayed { get; set; }

        [JsonProperty("maxTimeSpentLiving")]
        public int MaxTimeSpentLiving { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("maxTotalPlayerScore")]
        public int MaxTotalPlayerScore { get; set; }

        [JsonProperty("mostChampionKillsPerSession")]
        public int MostChampionKillsPerSession { get; set; }

        [JsonProperty("mostSpellsCast")]
        public int MostSpellsCast { get; set; }

        [JsonProperty("normalGamesPlayed")]
        public int NormalGamesPlayed { get; set; }

        [JsonProperty("rankedPremadeGamesPlayed")]
        public int RankedPremadeGamesPlayed { get; set; }

        [JsonProperty("rankedSoloGamesPlayed")]
        public int RankedSoloGamesPlayed { get; set; }

        [JsonProperty("totalAssists")]
        public int TotalAssists { get; set; }

        [JsonProperty("totalChampionKills")]
        public int TotalChampionKills { get; set; }

        [JsonProperty("totalDamageDealt")]
        public int TotalDamageDealt { get; set; }

        [JsonProperty("totalDamageTaken")]
        public int TotalDamageTaken { get; set; }

        /// <summary>
        /// Only returned for ranked statistics.
        /// </summary>
        [JsonProperty("totalDeathsPerSession")]
        public int TotalDeathsPerSession { get; set; }

        [JsonProperty("totalDoubleKills")]
        public int TotalDoubleKills { get; set; }

        [JsonProperty("totalFirstBlood")]
        public int TotalFirstBlood { get; set; }

        [JsonProperty("totalGoldEarned")]
        public int TotalGoldEarned { get; set; }

        [JsonProperty("totalHeal")]
        public int TotalHeal { get; set; }

        [JsonProperty("totalMagicDamageDealt")]
        public int TotalMagicDamageDealt { get; set; }

        [JsonProperty("totalMinionKills")]
        public int TotalMinionKills { get; set; }

        [JsonProperty("totalNeutralMinionsKilled")]
        public int TotalNeutralMinionsKilled { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("totalNodeCapture")]
        public int TotalNodeCapture { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty("totalNodeNeutralize")]
        public int TotalNodeNeutralize { get; set; }

        [JsonProperty("totalPentaKills")]
        public int TotalPentaKills { get; set; }

        [JsonProperty("totalPhysicalDamageDealt")]
        public int TotalPhysicalDamageDealt { get; set; }

        [JsonProperty("totalQuadraKills")]
        public int TotalQuadraKills { get; set; }

        [JsonProperty("totalSessionsLost")]
        public int TotalSessionsLost { get; set; }

        [JsonProperty("totalSessionsPlayed")]
        public int TotalSessionsPlayed { get; set; }

        [JsonProperty("totalSessionsWon")]
        public int TotalSessionsWon { get; set; }

        [JsonProperty("totalTripleKills")]
        public int TotalTripleKills { get; set; }

        [JsonProperty("totalTurretsKilled")]
        public int TotalTurretsKilled { get; set; }

        [JsonProperty("totalUnrealKills")]
        public int TotalUnrealKills { get; set; }
    }
}
