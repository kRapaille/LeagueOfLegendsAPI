using System;

namespace PortableLeagueApi.Interfaces.Enums
{
    [Flags]
    public enum ChampDataEnum
    {
        All = 0,
        Image = 1 << 0,
        Skins = 1 << 1,
        Lore = 1 << 2,
        Blurb = 1 << 3,
        Allytips = 1 << 4,
        Enemytips = 1 << 5,
        Tags = 1 << 6,
        Partytype = 1 << 7,
        Info = 1 << 8,
        Stats = 1 << 9,
        Spells = 1 << 10,
        Passive = 1 << 11,
        Recommended = 1 << 12
    }
}
