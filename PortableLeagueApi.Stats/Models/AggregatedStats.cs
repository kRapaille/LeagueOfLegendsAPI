using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Stats.Models.DTO;

namespace PortableLeagueApi.Stats.Models
{
    public class AggregatedStats : LeagueApiModel, IAggregatedStats
    {
        public int AverageAssists { get; set; }
        public int AverageChampionsKilled { get; set; }
        public int AverageCombatPlayerScore { get; set; }
        public int AverageNodeCapture { get; set; }
        public int AverageNodeCaptureAssist { get; set; }
        public int AverageNodeNeutralize { get; set; }
        public int AverageNodeNeutralizeAssist { get; set; }
        public int AverageNumDeaths { get; set; }
        public int AverageObjectivePlayerScore { get; set; }
        public int AverageTeamObjective { get; set; }
        public int AverageTotalPlayerScore { get; set; }
        public int BotGamesPlayed { get; set; }
        public int KillingSpree { get; set; }
        public int MaxAssists { get; set; }
        public int MaxChampionsKilled { get; set; }
        public int MaxCombatPlayerScore { get; set; }
        public int MaxLargestCriticalStrike { get; set; }
        public int MaxLargestKillingSpree { get; set; }
        public int MaxNodeCapture { get; set; }
        public int MaxNodeCaptureAssist { get; set; }
        public int MaxNodeNeutralize { get; set; }
        public int MaxNodeNeutralizeAssist { get; set; }
        public int MaxNumDeaths { get; set; }
        public int MaxObjectivePlayerScore { get; set; }
        public int MaxTeamObjective { get; set; }
        public int MaxTimePlayed { get; set; }
        public int MaxTimeSpentLiving { get; set; }
        public int MaxTotalPlayerScore { get; set; }
        public int MostChampionKillsPerSession { get; set; }
        public int MostSpellsCast { get; set; }
        public int NormalGamesPlayed { get; set; }
        public int RankedPremadeGamesPlayed { get; set; }
        public int RankedSoloGamesPlayed { get; set; }
        public int TotalAssists { get; set; }
        public int TotalChampionKills { get; set; }
        public int TotalDamageDealt { get; set; }
        public int TotalDamageTaken { get; set; }
        public int TotalDeathsPerSession { get; set; }
        public int TotalDoubleKills { get; set; }
        public int TotalFirstBlood { get; set; }
        public int TotalGoldEarned { get; set; }
        public int TotalHeal { get; set; }
        public int TotalMagicDamageDealt { get; set; }
        public int TotalMinionKills { get; set; }
        public int TotalNeutralMinionsKilled { get; set; }
        public int TotalNodeCapture { get; set; }
        public int TotalNodeNeutralize { get; set; }
        public int TotalPentaKills { get; set; }
        public int TotalPhysicalDamageDealt { get; set; }
        public int TotalQuadraKills { get; set; }
        public int TotalSessionsLost { get; set; }
        public int TotalSessionsPlayed { get; set; }
        public int TotalSessionsWon { get; set; }
        public int TotalTripleKills { get; set; }
        public int TotalTurretsKilled { get; set; }
        public int TotalUnrealKills { get; set; }

        public static void CreateMap(ILeagueAPI source)
        {
            Mapper.CreateMap<AggregatedStatsDto, IAggregatedStats>().As<AggregatedStats>();
            Mapper.CreateMap<AggregatedStatsDto, AggregatedStats>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });
        }
    }
}
