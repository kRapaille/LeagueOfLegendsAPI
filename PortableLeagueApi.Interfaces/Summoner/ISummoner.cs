using System;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface ISummoner : ILeagueModel
    {
        /// <summary>
        /// Summoner Id.
        /// </summary>
        long SummonerId { get; set; }
        /// <summary>
        /// Summoner name.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Id of the summoner icon associated with the summoner.
        /// </summary>
        int ProfileIconId { get; set; }
        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds.
        /// </summary>
        DateTime RevisionDate { get; set; }
        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        long SummonerLevel { get; set; }
    }
}