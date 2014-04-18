using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface ISpellVars : IApiModel
    {
        IList<float> Coeff { get; set; }
        string Dyn { get; set; }
        string Key { get; set; }
        string Link { get; set; }
        string RanksWith { get; set; }
    }
}