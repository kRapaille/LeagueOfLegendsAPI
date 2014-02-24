using System;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface ISummoner
    {
        long SummonerId { get; set; }
        string Name { get; set; }
        int ProfileIconId { get; set; }
        DateTime RevisionDate { get; set; }
        long SummonerLevel { get; set; }
    }
}