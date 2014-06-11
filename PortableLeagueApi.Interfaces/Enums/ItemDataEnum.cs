using System;

namespace PortableLeagueApi.Interfaces.Enums
{
    [Flags]
    public enum ItemDataEnum
    {
        All = 0,
        Description = 1 << 0,
        Colloq = 1 << 1,
        Into = 1 << 2,
        Image = 1 << 3,
        Gold = 1 << 4,
        Tags = 1 << 5,
        Stats = 1 << 6,
        Groups = 1 << 7,
        Tree = 1 << 8
    }
}
