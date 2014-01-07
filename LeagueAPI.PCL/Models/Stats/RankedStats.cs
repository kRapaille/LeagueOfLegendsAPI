using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Stats
{
    public class RankedStats
    {
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        [JsonProperty("champions")]
        public Champion.Champion[] Champions { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class RankedStatsChampion
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Stats
    {
        [JsonProperty("totalSessionsPlayed")]
        public int TotalSessionsPlayed { get; set; }

        [JsonProperty("totalDamageTaken")]
        public int TotalDamageTaken { get; set; }

        [JsonProperty("totalQuadraKills")]
        public int TotalQuadraKills { get; set; }

        [JsonProperty("totalTripleKills")]
        public int TotalTripleKills { get; set; }

        [JsonProperty("totalMinionKills")]
        public int TotalMinionKills { get; set; }

        [JsonProperty("maxChampionsKilled")]
        public int MaxChampionsKilled { get; set; }

        [JsonProperty("totalDoubleKills")]
        public int TotalDoubleKills { get; set; }

        [JsonProperty("totalPhysicalDamageDealt")]
        public int TotalPhysicalDamageDealt { get; set; }

        [JsonProperty("totalChampionKills")]
        public int TotalChampionKills { get; set; }

        [JsonProperty("totalAssists")]
        public int TotalAssists { get; set; }

        [JsonProperty("mostChampionKillsPerSession")]
        public int MostChampionKillsPerSession { get; set; }

        [JsonProperty("totalDamageDealt")]
        public int TotalDamageDealt { get; set; }

        [JsonProperty("totalFirstBlood")]
        public int TotalFirstBlood { get; set; }

        [JsonProperty("totalSessionsLost")]
        public int TotalSessionsLost { get; set; }

        [JsonProperty("totalSessionsWon")]
        public int TotalSessionsWon { get; set; }

        [JsonProperty("totalMagicDamageDealt")]
        public int TotalMagicDamageDealt { get; set; }

        [JsonProperty("totalGoldEarned")]
        public int TotalGoldEarned { get; set; }

        [JsonProperty("totalPentaKills")]
        public int TotalPentaKills { get; set; }

        [JsonProperty("totalTurretsKilled")]
        public int TotalTurretsKilled { get; set; }

        [JsonProperty("mostSpellsCast")]
        public int MostSpellsCast { get; set; }

        [JsonProperty("totalUnrealKills")]
        public int TotalUnrealKills { get; set; }

        [JsonProperty("maxLargestCriticalStrike")]
        public int MaxLargestCriticalStrike { get; set; }

        [JsonProperty("rankedPremadeGamesPlayed")]
        public int RankedPremadeGamesPlayed { get; set; }

        [JsonProperty("totalNeutralMinionsKilled")]
        public int TotalNeutralMinionsKilled { get; set; }

        [JsonProperty("maxLargestKillingSpree")]
        public int MaxLargestKillingSpree { get; set; }

        [JsonProperty("maxTimeSpentLiving")]
        public int MaxTimeSpentLiving { get; set; }

        [JsonProperty("maxTimePlayed")]
        public int MaxTimePlayed { get; set; }

        [JsonProperty("botGamesPlayed")]
        public int BotGamesPlayed { get; set; }

        [JsonProperty("killingSpree")]
        public int KillingSpree { get; set; }

        [JsonProperty("rankedSoloGamesPlayed")]
        public int RankedSoloGamesPlayed { get; set; }

        [JsonProperty("totalHeal")]
        public int TotalHeal { get; set; }

        [JsonProperty("normalGamesPlayed")]
        public int NormalGamesPlayed { get; set; }
    }
}
