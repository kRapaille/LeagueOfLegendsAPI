using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.SummonerSpell
{
    public interface ISummonerSpellList : IApiModel
    {
        Dictionary<string, ISummonerSpell> Data { get; set; }
        string Type { get; set; }
        string Version { get; set; }
    }
}