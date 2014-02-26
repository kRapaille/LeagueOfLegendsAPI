using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.SummonerSpell
{
    public interface ISummonerSpellVars : IApiModel
    {
        IList<float> Coeff { get; set; }
        string Key { get; set; }
        string Link { get; set; }
    }
}