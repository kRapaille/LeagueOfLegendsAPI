using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Game
{
    public interface IRawStats : IHasItemIds, IHasSummonerSpells
    {
        int Assists { get; set; }
        int BarracksKilled { get; set; }
        int ChampionsKilled { get; set; }
        int CombatPlayerScore { get; set; }
        int ConsumablesPurchased { get; set; }
        int DamageDealtPlayer { get; set; }
        int DoubleKills { get; set; }
        int FirstBlood { get; set; }
        int Gold { get; set; }
        int GoldEarned { get; set; }
        int GoldSpent { get; set; }
        int ItemsPurchased { get; set; }
        int KillingSprees { get; set; }
        int LargestCriticalStrike { get; set; }
        int LargestKillingSpree { get; set; }
        int LargestMultiKill { get; set; }
        /// <summary>
        /// Number of tier 3 items built.
        /// </summary>
        int LegendaryItemsCreated { get; set; }
        int Level { get; set; }
        int MagicDamageDealtPlayer { get; set; }
        int MagicDamageDealtToChampions { get; set; }
        int MagicDamageTaken { get; set; }
        int MinionsDenied { get; set; }
        int MinionsKilled { get; set; }
        int NeutralMinionsKilled { get; set; }
        int NeutralMinionsKilledEnemyJungle { get; set; }
        int NeutralMinionsKilledYourJungle { get; set; }
        /// <summary>
        /// Flag specifying if the summoner got the killing blow on the nexus.
        /// </summary>
        bool NexusKilled { get; set; }
        int NodeCapture { get; set; }
        int NodeCaptureAssist { get; set; }
        int NodeNeutralize { get; set; }
        int NodeNeutralizeAssist { get; set; }
        int NumDeaths { get; set; }
        int NumItemsBought { get; set; }
        int ObjectivePlayerScore { get; set; }
        int PentaKills { get; set; }
        int PhysicalDamageDealtPlayer { get; set; }
        int PhysicalDamageDealtToChampions { get; set; }
        int PhysicalDamageTaken { get; set; }
        int QuadraKills { get; set; }
        int SightWardsBought { get; set; }
        /// <summary>
        /// Number of times first champion spell was cast.
        /// </summary>
        int Spell1Cast { get; set; }
        /// <summary>
        /// Number of times second champion spell was cast.
        /// </summary>
        int Spell2Cast { get; set; }
        /// <summary>
        /// Number of times third champion spell was cast.
        /// </summary>
        int Spell3Cast { get; set; }
        /// <summary>
        /// Number of times fourth champion spell was cast.
        /// </summary>
        int Spell4Cast { get; set; }
        int SuperMonsterKilled { get; set; }
        int Team { get; set; }
        int TeamObjective { get; set; }
        int TimePlayed { get; set; }
        int TotalDamageDealt { get; set; }
        int TotalDamageDealtToChampions { get; set; }
        int TotalDamageTaken { get; set; }
        int TotalHeal { get; set; }
        int TotalPlayerScore { get; set; }
        int TotalScoreRank { get; set; }
        int TotalTimeCrowdControlDealt { get; set; }
        int TotalUnitsHealed { get; set; }
        int TripleKills { get; set; }
        int TrueDamageDealtPlayer { get; set; }
        int TrueDamageDealtToChampions { get; set; }
        int TrueDamageTaken { get; set; }
        int TurretsKilled { get; set; }
        int UnrealKills { get; set; }
        int VictoryPointTotal { get; set; }
        int VisionWardsBought { get; set; }
        int WardKilled { get; set; }
        int WardPlaced { get; set; }
        /// <summary>
        /// Flag specifying whether or not this game was won.
        /// </summary>
        bool Win { get; set; }
    }
}