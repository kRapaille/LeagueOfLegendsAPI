using System.Collections.Generic;
using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Game.Models.DTO;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Game;

namespace PortableLeagueApi.Game.Models
{
    public class RawStats : LeagueApiModel, IRawStats
    {
        public int Assists { get; set; }
        public int BarracksKilled { get; set; }
        public int ChampionsKilled { get; set; }
        public int CombatPlayerScore { get; set; }
        public int ConsumablesPurchased { get; set; }
        public int DamageDealtPlayer { get; set; }
        public int DoubleKills { get; set; }
        public int FirstBlood { get; set; }
        public int Gold { get; set; }
        public int GoldEarned { get; set; }
        public int GoldSpent { get; set; }
        public IList<int> ItemIds { get; set; }
        public int ItemsPurchased { get; set; }
        public int KillingSprees { get; set; }
        public int LargestCriticalStrike { get; set; }
        public int LargestKillingSpree { get; set; }
        public int LargestMultiKill { get; set; }
        public int LegendaryItemsCreated { get; set; }
        public int Level { get; set; }
        public int MagicDamageDealtPlayer { get; set; }
        public int MagicDamageDealtToChampions { get; set; }
        public int MagicDamageTaken { get; set; }
        public int MinionsDenied { get; set; }
        public int MinionsKilled { get; set; }
        public int NeutralMinionsKilled { get; set; }
        public int NeutralMinionsKilledEnemyJungle { get; set; }
        public int NeutralMinionsKilledYourJungle { get; set; }
        public bool NexusKilled { get; set; }
        public int NodeCapture { get; set; }
        public int NodeCaptureAssist { get; set; }
        public int NodeNeutralize { get; set; }
        public int NodeNeutralizeAssist { get; set; }
        public int NumDeaths { get; set; }
        public int NumItemsBought { get; set; }
        public int ObjectivePlayerScore { get; set; }
        public int PentaKills { get; set; }
        public int PhysicalDamageDealtPlayer { get; set; }
        public int PhysicalDamageDealtToChampions { get; set; }
        public int PhysicalDamageTaken { get; set; }
        public int QuadraKills { get; set; }
        public int SightWardsBought { get; set; }
        public int Spell1Cast { get; set; }
        public int Spell2Cast { get; set; }
        public int Spell3Cast { get; set; }
        public int Spell4Cast { get; set; }
        public int SummonerSpell1 { get; set; }
        public int SummonerSpell2 { get; set; }
        public int SuperMonsterKilled { get; set; }
        public int Team { get; set; }
        public int TeamObjective { get; set; }
        public int TimePlayed { get; set; }
        public int TotalDamageDealt { get; set; }
        public int TotalDamageDealtToChampions { get; set; }
        public int TotalDamageTaken { get; set; }
        public int TotalHeal { get; set; }
        public int TotalPlayerScore { get; set; }
        public int TotalScoreRank { get; set; }
        public int TotalTimeCrowdControlDealt { get; set; }
        public int TotalUnitsHealed { get; set; }
        public int TripleKills { get; set; }
        public int TrueDamageDealtPlayer { get; set; }
        public int TrueDamageDealtToChampions { get; set; }
        public int TrueDamageTaken { get; set; }
        public int TurretsKilled { get; set; }
        public int UnrealKills { get; set; }
        public int VictoryPointTotal { get; set; }
        public int VisionWardsBought { get; set; }
        public int WardKilled { get; set; }
        public int WardPlaced { get; set; }
        public bool Win { get; set; }

        internal static void CreateMap(ILeagueAPI source)
        {
            Mapper.CreateMap<RawStatsDto, IRawStats>().As<RawStats>();
            Mapper.CreateMap<RawStatsDto, RawStats>()
                .ForSourceMember(x => x.Item0, x => x.Ignore())
                .ForSourceMember(x => x.Item1, x => x.Ignore())
                .ForSourceMember(x => x.Item2, x => x.Ignore())
                .ForSourceMember(x => x.Item3, x => x.Ignore())
                .ForSourceMember(x => x.Item4, x => x.Ignore())
                .ForSourceMember(x => x.Item5, x => x.Ignore())
                .ForSourceMember(x => x.Item6, x => x.Ignore())
                .BeforeMap((s, d) =>
                {
                    d.Source = source;

                    d.ItemIds = new List<int>
                                {
                                    s.Item0,
                                    s.Item1,
                                    s.Item2,
                                    s.Item3,
                                    s.Item4,
                                    s.Item5,
                                    s.Item6,
                                };
                });
        }
    }
}