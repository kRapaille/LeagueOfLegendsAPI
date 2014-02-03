using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Stats
{
    public class PlayerStatsSummaryListDto
    {
        /// <summary>
        /// List of player stats summaries associated with the summoner.
        /// </summary>
        [JsonProperty("playerStatSummaries")]
        public PlayerStatsSummaryDto[] PlayerStatSummaries { get; set; }
        
        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class PlayerStatsSummaryDto
    {
        /// <summary>
        /// Player stats value type. (legal values: AramUnranked5x5, CoopVsAI, CoopVsAI3x3, OdinUnranked, RankedPremade3x3, RankedPremade5x5, RankedSolo5x5, RankedTeam3x3, RankedTeam5x5, Unranked, Unranked3x3, OneForAll5x5, FirstBlood1x1, FirstBlood2x2)
        /// </summary>
        [JsonProperty("playerStatSummaryType")]
        public string PlayerStatSummaryType { get; set; }

        /// <summary>
        /// Aggregated stats.
        /// </summary>
        [JsonProperty("aggregatedStats")]
        public AggregatedStatsDto AggregatedStats { get; set; }

        /// <summary>
        /// Number of losses for this queue type. Returned for ranked queue types only.
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        /// <summary>
        /// CNumber of wins for this queue type.
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}