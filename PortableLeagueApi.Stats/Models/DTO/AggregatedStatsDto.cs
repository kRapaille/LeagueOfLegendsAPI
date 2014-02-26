using Newtonsoft.Json;

namespace PortableLeagueApi.Stats.Models.DTO
{
    internal class AggregatedStatsDto
    {
        [JsonProperty("averageAssists")]
        public int AverageAssists { get; set; }

        [JsonProperty("averageChampionsKilled")]
        public int AverageChampionsKilled { get; set; }

        [JsonProperty("averageCombatPlayerScore")]
        public int AverageCombatPlayerScore { get; set; }

        [JsonProperty("averageNodeCapture")]
        public int AverageNodeCapture { get; set; }

        [JsonProperty("averageNodeCaptureAssist")]
        public int AverageNodeCaptureAssist { get; set; }

        [JsonProperty("averageNodeNeutralize")]
        public int AverageNodeNeutralize { get; set; }

        [JsonProperty("averageNodeNeutralizeAssist")]
        public int AverageNodeNeutralizeAssist { get; set; }

        [JsonProperty("averageNumDeaths")]
        public int AverageNumDeaths { get; set; }

        [JsonProperty("averageObjectivePlayerScore")]
        public int AverageObjectivePlayerScore { get; set; }

        [JsonProperty("averageTeamObjective")]
        public int AverageTeamObjective { get; set; }

        [JsonProperty("averageTotalPlayerScore")]
        public int AverageTotalPlayerScore { get; set; }

        [JsonProperty("botGamesPlayed")]
        public int BotGamesPlayed { get; set; }

        [JsonProperty("killingSpree")]
        public int KillingSpree { get; set; }

        [JsonProperty("maxAssists")]
        public int MaxAssists { get; set; }

        [JsonProperty("maxChampionsKilled")]
        public int MaxChampionsKilled { get; set; }

        [JsonProperty("maxCombatPlayerScore")]
        public int MaxCombatPlayerScore { get; set; }

        [JsonProperty("maxLargestCriticalStrike")]
        public int MaxLargestCriticalStrike { get; set; }

        [JsonProperty("maxLargestKillingSpree")]
        public int MaxLargestKillingSpree { get; set; }

        [JsonProperty("maxNodeCapture")]
        public int MaxNodeCapture { get; set; }

        [JsonProperty("maxNodeCaptureAssist")]
        public int MaxNodeCaptureAssist { get; set; }

        [JsonProperty("maxNodeNeutralize")]
        public int MaxNodeNeutralize { get; set; }

        [JsonProperty("maxNodeNeutralizeAssist")]
        public int MaxNodeNeutralizeAssist { get; set; }

        [JsonProperty("maxNumDeaths")]
        public int MaxNumDeaths { get; set; }

        [JsonProperty("maxObjectivePlayerScore")]
        public int MaxObjectivePlayerScore { get; set; }

        [JsonProperty("maxTeamObjective")]
        public int MaxTeamObjective { get; set; }

        [JsonProperty("maxTimePlayed")]
        public int MaxTimePlayed { get; set; }

        [JsonProperty("maxTimeSpentLiving")]
        public int MaxTimeSpentLiving { get; set; }

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

        [JsonProperty("totalNodeCapture")]
        public int TotalNodeCapture { get; set; }

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
