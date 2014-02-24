using System;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IRankedStats : ILeagueModel
    {
        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        DateTime ModifyDate { get; set; }
        /// <summary>
        /// List of aggregated stats summarized by champion.
        /// </summary>
        IChampionStats[] Champions { get; set; }
        /// <summary>
        /// Summoner Id.
        /// </summary>
        long SummonerId { get; set; }
    }
}