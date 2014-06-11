using System;

namespace PortableLeagueApi.Interfaces.Enums
{
    [Flags]
    public enum RuneDataEnum
    {
        All = 0,
        Image = 1 << 0,
        Stats = 1 << 1,
        Tags = 1 << 2,
        Colloq = 1 << 3,
        Plaintext = 1 << 4,
        Basic = 1 << 5
    }
}