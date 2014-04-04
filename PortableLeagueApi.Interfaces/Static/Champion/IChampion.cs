using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IChampion : IApiModel
    {
        IList<string> AllyTips { get; set; }
        string Blurb { get; set; }
        IList<string> Enemytips { get; set; }
        int Id { get; set; }
        IImage Image { get; set; }
        IInfo Info { get; set; }
        string Key { get; set; }
        string Lore { get; set; }
        string Name { get; set; }
        string Partype { get; set; }
        IPassive Passive { get; set; }
        IList<IRecommended> Recommended { get; set; }
        IList<ISkin> Skins { get; set; }
        IList<ISpell> Spells { get; set; }
        IStats Stats { get; set; }
        IList<string> Tags { get; set; }
        string Title { get; set; }
    }
}