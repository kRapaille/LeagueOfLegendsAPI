using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Constants
{
    public class LeagueTypeConsts 
    {
        public const string RankedSolo5X5 = "RANKED_SOLO_5x5";
        public const string RankedTeam3X3 = "RANKED_TEAM_3x3";
        public const string RankedTeam5X5 = "RANKED_TEAM_5x5";

        public static readonly Dictionary<LeagueTypeEnum, string> LeagueTypes = new Dictionary<LeagueTypeEnum, string>
        {
            { LeagueTypeEnum.RankedSolo5X5, RankedSolo5X5 },
            { LeagueTypeEnum.RankedTeam3X3, RankedTeam3X3 },
            { LeagueTypeEnum.RankedTeam5X5, RankedTeam5X5 }
        };
    }
}
