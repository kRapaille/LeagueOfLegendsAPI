using Newtonsoft.Json;

namespace PortableLeagueApi.Game.Models.DTO
{
    internal class RawStatsDto
    {
        [JsonProperty("assists")]
        internal int Assists { get; set; }

        [JsonProperty("barracksKilled")]
        internal int BarracksKilled { get; set; }

        [JsonProperty("championsKilled")]
        internal int ChampionsKilled { get; set; }

        [JsonProperty("combatPlayerScore")]
        internal int CombatPlayerScore { get; set; }

        [JsonProperty("consumablesPurchased")]
        internal int ConsumablesPurchased { get; set; }

        [JsonProperty("damageDealtPlayer")]
        internal int DamageDealtPlayer { get; set; }

        [JsonProperty("doubleKills")]
        internal int DoubleKills { get; set; }

        [JsonProperty("firstBlood")]
        internal int FirstBlood { get; set; }

        [JsonProperty("gold")]
        internal int Gold { get; set; }

        [JsonProperty("goldEarned")]
        internal int GoldEarned { get; set; }

        [JsonProperty("goldSpent")]
        internal int GoldSpent { get; set; }

        [JsonProperty("item0")]
        internal int Item0 { get; set; }

        [JsonProperty("item1")]
        internal int Item1 { get; set; }

        [JsonProperty("item2")]
        internal int Item2 { get; set; }

        [JsonProperty("item3")]
        internal int Item3 { get; set; }

        [JsonProperty("item4")]
        internal int Item4 { get; set; }

        [JsonProperty("item5")]
        internal int Item5 { get; set; }

        [JsonProperty("item6")]
        internal int Item6 { get; set; }

        [JsonProperty("itemsPurchased")]
        internal int ItemsPurchased { get; set; }

        [JsonProperty("killingSprees")]
        internal int KillingSprees { get; set; }

        [JsonProperty("largestCriticalStrike")]
        internal int LargestCriticalStrike { get; set; }

        [JsonProperty("largestKillingSpree")]
        internal int LargestKillingSpree { get; set; }

        [JsonProperty("largestMultiKill")]
        internal int LargestMultiKill { get; set; }

        [JsonProperty("legendaryItemsCreated")]
        internal int LegendaryItemsCreated { get; set; }

        [JsonProperty("level")]
        internal int Level { get; set; }

        [JsonProperty("magicDamageDealtPlayer")]
        internal int MagicDamageDealtPlayer { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        internal int MagicDamageDealtToChampions { get; set; }

        [JsonProperty("magicDamageTaken")]
        internal int MagicDamageTaken { get; set; }

        [JsonProperty("minionsDenied")]
        internal int MinionsDenied { get; set; }

        [JsonProperty("minionsKilled")]
        internal int MinionsKilled { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        internal int NeutralMinionsKilled { get; set; }

        [JsonProperty("neutralMinionsKilledEnemyJungle")]
        internal int NeutralMinionsKilledEnemyJungle { get; set; }

        [JsonProperty("neutralMinionsKilledYourJungle")]
        internal int NeutralMinionsKilledYourJungle { get; set; }

        [JsonProperty("nexusKilled")]
        internal bool NexusKilled { get; set; }

        [JsonProperty("nodeCapture")]
        internal int NodeCapture { get; set; }

        [JsonProperty("nodeCaptureAssist")]
        internal int NodeCaptureAssist { get; set; }

        [JsonProperty("nodeNeutralize")]
        internal int NodeNeutralize { get; set; }

        [JsonProperty("nodeNeutralizeAssist")]
        internal int NodeNeutralizeAssist { get; set; }

        [JsonProperty("numDeaths")]
        internal int NumDeaths { get; set; }

        [JsonProperty("numItemsBought")]
        internal int NumItemsBought { get; set; }

        [JsonProperty("objectivePlayerScore")]
        internal int ObjectivePlayerScore { get; set; }

        [JsonProperty("pentaKills")]
        internal int PentaKills { get; set; }

        [JsonProperty("physicalDamageDealtPlayer")]
        internal int PhysicalDamageDealtPlayer { get; set; }

        [JsonProperty("physicalDamageDealtToChampions")]
        internal int PhysicalDamageDealtToChampions { get; set; }

        [JsonProperty("physicalDamageTaken")]
        internal int PhysicalDamageTaken { get; set; }

        [JsonProperty("quadraKills")]
        internal int QuadraKills { get; set; }

        [JsonProperty("sightWardsBought")]
        internal int SightWardsBought { get; set; }

        [JsonProperty("spell1Cast")]
        internal int Spell1Cast { get; set; }

        [JsonProperty("spell2Cast")]
        internal int Spell2Cast { get; set; }

        [JsonProperty("spell3Cast")]
        internal int Spell3Cast { get; set; }

        [JsonProperty("spell4Cast")]
        internal int Spell4Cast { get; set; }

        [JsonProperty("summonSpell1Cast")]
        internal int SummonerSpell1 { get; set; }

        [JsonProperty("summonSpell2Cast")]
        internal int SummonerSpell2 { get; set; }

        [JsonProperty("superMonsterKilled")]
        internal int SuperMonsterKilled { get; set; }

        [JsonProperty("team")]
        internal int Team { get; set; }

        [JsonProperty("teamObjective")]
        internal int TeamObjective { get; set; }

        [JsonProperty("timePlayed")]
        internal int TimePlayed { get; set; }

        [JsonProperty("totalDamageDealt")]
        internal int TotalDamageDealt { get; set; }

        [JsonProperty("totalDamageDealtToChampions")]
        internal int TotalDamageDealtToChampions { get; set; }

        [JsonProperty("totalDamageTaken")]
        internal int TotalDamageTaken { get; set; }

        [JsonProperty("totalHeal")]
        internal int TotalHeal { get; set; }

        [JsonProperty("totalPlayerScore")]
        internal int TotalPlayerScore { get; set; }

        [JsonProperty("totalScoreRank")]
        internal int TotalScoreRank { get; set; }

        [JsonProperty("totalTimeCrowdControlDealt")]
        internal int TotalTimeCrowdControlDealt { get; set; }

        [JsonProperty("totalUnitsHealed")]
        internal int TotalUnitsHealed { get; set; }

        [JsonProperty("tripleKills")]
        internal int TripleKills { get; set; }

        [JsonProperty("trueDamageDealtPlayer")]
        internal int TrueDamageDealtPlayer { get; set; }

        [JsonProperty("trueDamageDealtToChampions")]
        internal int TrueDamageDealtToChampions { get; set; }

        [JsonProperty("trueDamageTaken")]
        internal int TrueDamageTaken { get; set; }

        [JsonProperty("turretsKilled")]
        internal int TurretsKilled { get; set; }

        [JsonProperty("unrealKills")]
        internal int UnrealKills { get; set; }

        [JsonProperty("victoryPointTotal")]
        internal int VictoryPointTotal { get; set; }

        [JsonProperty("visionWardsBought")]
        internal int VisionWardsBought { get; set; }

        [JsonProperty("wardKilled")]
        internal int WardKilled { get; set; }

        [JsonProperty("wardPlaced")]
        internal int WardPlaced { get; set; }

        [JsonProperty("win")]
        internal bool Win { get; set; }
    }
}