using System;

namespace PortableLeagueApi.Interfaces.Enums
{
    [Flags]
    public enum SpellDataEnum
    {
        All = 0,
        Key = 1 << 0,
        Image = 1 << 1,
        Tooltip = 1 << 2,
        Ressource = 1 << 3,
        MaxRank = 1 << 4,
        Modes = 1 << 5,
        CostType = 1 << 6,
        Cost = 1 << 7,
        CostBurn = 1 << 8,
        Range = 1 << 9,
        RangeBurn = 1 << 10,
        Effect = 1 << 11,
        EffectBurn = 1 << 12,
        Cooldown = 1 << 13,
        CooldownBurn = 1 << 14,
        Vars = 1 << 15
    }
}