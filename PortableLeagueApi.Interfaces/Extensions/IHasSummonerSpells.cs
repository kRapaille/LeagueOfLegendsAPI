using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Extensions
{
    public interface IHasSummonerSpells : IApiModel
    {
        /// <summary>
        /// Summoner spells
        /// </summary>
        IList<int> SummonerSpells { get; set; }
    }
}