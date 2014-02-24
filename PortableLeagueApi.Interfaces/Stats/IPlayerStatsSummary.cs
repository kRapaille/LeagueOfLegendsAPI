using System;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IPlayerStatsSummary : ILeagueModel
    {
        /// <summary>
        /// Player stats value type. (legal values: AramUnranked5x5, CoopVsAI, CoopVsAI3x3, OdinUnranked, RankedPremade3x3, RankedPremade5x5, RankedSolo5x5, RankedTeam3x3, RankedTeam5x5, Unranked, Unranked3x3, OneForAll5x5, FirstBlood1x1, FirstBlood2x2)
        /// </summary>
        PlayerStatsSummaryTypeEnum PlayerStatsSummaryType { get; set; }
        /// <summary>
        /// Aggregated stats.
        /// </summary>
        IAggregatedStats AggregatedStats { get; set; }
        /// <summary>
        /// Number of losses for this queue type. Returned for ranked queue types only.
        /// </summary>
        int Losses { get; set; }
        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        DateTime ModifyDate { get; set; }
        /// <summary>
        /// Number of wins for this queue type.
        /// </summary>
        int Wins { get; set; }
    }
}