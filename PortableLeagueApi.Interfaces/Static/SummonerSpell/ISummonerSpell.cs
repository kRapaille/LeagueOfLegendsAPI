using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.SummonerSpell
{
    public interface ISummonerSpell : IApiModel
    {
        IList<int> Cooldown { get; set; }
        string CooldownBurn { get; set; }
        IList<int> Cost { get; set; }
        string CostBurn { get; set; }
        string CostType { get; set; }
        string Description { get; set; }
        IList<IList<float>> Effect { get; set; }
        IList<string> EffectBurn { get; set; }
        string Id { get; set; }
        IImage Image { get; set; }
        string Key { get; set; }
        ILevelTip Leveltip { get; set; }
        int MaxRank { get; set; }
        IList<string> Modes { get; set; }
        string Name { get; set; }
        int Range { get; set; }
        string RangeBurn { get; set; }
        string Resource { get; set; }
        int SummonerLevel { get; set; }
        string Tooltip { get; set; }
        IList<ISummonerSpellVars> Vars { get; set; }
    }
}