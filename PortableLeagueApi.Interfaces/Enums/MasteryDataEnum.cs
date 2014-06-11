using System;

namespace PortableLeagueApi.Interfaces.Enums
{
    [Flags]
    public enum MasteryDataEnum
    {
        All = 0,
        Ranks = 1 << 0,
        Prereq = 1 << 1,
        Image = 1 << 2,
        Tree = 1 << 3
    }
}