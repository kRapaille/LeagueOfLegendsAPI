using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Constants
{
    internal class VersionConsts
    {
        public const string V1 = "v1";
        public const string V1Rev1 = "v1.1";
        public const string V1Rev2 = "v1.2";
        public const string V1Rev3 = "v1.3";
        public const string V1Rev4 = "v1.4";
        public const string V2Rev1 = "v2.1";
        public const string V2Rev2 = "v2.2";
        public const string V2Rev3 = "v2.3";
        public const string V2Rev4 = "v2.4";
        public const string V2Rev5 = "v2.5";

        internal static readonly Dictionary<VersionEnum, string> Versions = new Dictionary<VersionEnum, string>
        {
            { VersionEnum.V1, V1 },
            { VersionEnum.V1Rev1, V1Rev1 },
            { VersionEnum.V1Rev2, V1Rev2 },
            { VersionEnum.V1Rev3, V1Rev3 },
            { VersionEnum.V1Rev4, V1Rev4 },
            { VersionEnum.V2Rev1, V2Rev1 },
            { VersionEnum.V2Rev2, V2Rev2 },
            { VersionEnum.V2Rev3, V2Rev3 },
            { VersionEnum.V2Rev4, V2Rev4 },
            { VersionEnum.V2Rev5, V2Rev5 }
        };
    }
}
