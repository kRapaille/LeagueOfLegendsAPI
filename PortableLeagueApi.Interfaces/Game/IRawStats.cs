using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Game
{
    public interface IRawStats : ILeagueModel
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
        IList<int> ItemIds { get; set; }
        int ItemsPurchased { get; set; }
        int KillingSprees { get; set; }
        int LargestCriticalStrike { get; set; }
        int LargestKillingSpree { get; set; }
        int LargestMultiKill { get; set; }
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
        int Spell1Cast { get; set; }
        int Spell2Cast { get; set; }
        int Spell3Cast { get; set; }
        int Spell4Cast { get; set; }
        int SummonerSpell1 { get; set; }
        int SummonerSpell2 { get; set; }
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
        bool Win { get; set; }
    }
}