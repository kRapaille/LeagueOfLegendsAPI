using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface ISpell : IApiModel
    {
        IList<IImage> AltImages { get; set; }
        IList<double> Cooldown { get; set; }
        string CooldownBurn { get; set; }
        IList<int> Cost { get; set; }
        string CostBurn { get; set; }
        string CostType { get; set; }
        string Description { get; set; }
        IList<IList<int>> Effect { get; set; }
        IList<string> EffectBurn { get; set; }
        string Key { get; set; }
        IImage Image { get; set; }
        ILevelTip Leveltip { get; set; }
        int Maxrank { get; set; }
        string Name { get; set; }
        object Range { get; set; }
        string RangeBurn { get; set; }
        string Resource { get; set; }
        string SanitizedDescription { get; set; }
        string SanitizedTooltip { get; set; }
        string Tooltip { get; set; }
        IList<ISpellVars> Vars { get; set; }
    }
}