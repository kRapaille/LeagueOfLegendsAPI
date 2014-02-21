using System;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IPlayerStatsSummary
    {
        GameSubTypeEnum PlayerStatsSummaryType { get; set; }
        IAggregatedStats AggregatedStats { get; set; }
        int Losses { get; set; }
        DateTime ModifyDate { get; set; }
        int Wins { get; set; }
    }
}