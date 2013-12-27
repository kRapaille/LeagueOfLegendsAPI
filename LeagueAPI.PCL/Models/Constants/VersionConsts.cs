using System.Collections.Generic;
using LeagueAPI.PCL.Models.Enums;

namespace LeagueAPI.PCL.Models.Constants
{
    public class VersionConsts
    {
        public const string V1Rev1 = "v1.1";
        public const string V1Rev2 = "v1.2";
        public const string V2Rev1 = "v2.1";
        public const string V2Rev2 = "v2.2";

        public static readonly Dictionary<VersionEnum, string> Versions = new Dictionary<VersionEnum, string>
        {
            { VersionEnum.V1Rev1, V1Rev1 },
            { VersionEnum.V1Rev2, V1Rev2 },
            { VersionEnum.V2Rev1, V2Rev1 },
            { VersionEnum.V2Rev2, V2Rev2 }
        };
    }
}
