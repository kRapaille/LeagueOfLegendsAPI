using System;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface ISummoner : ILeagueModel
    {
        long SummonerId { get; set; }
        string Name { get; set; }
        int ProfileIconId { get; set; }
        DateTime RevisionDate { get; set; }
        long SummonerLevel { get; set; }
    }
}