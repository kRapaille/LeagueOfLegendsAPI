using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Constants
{
    public class GameSubTypeConsts
    {
        public const string None = "NONE";
        public const string Normal = "NORMAL";
        public const string Bot = "BOT";
        public const string RankedSolo5X5 = "RANKED_SOLO_5x5";
        public const string RankedPremade3X3 = "RANKED_PREMADE_3x3";
        public const string RankedPremade5X5 = "RANKED_PREMADE_5x5";
        public const string ODINUnranked = "ODIN_UNRANKED";
        public const string RankedTeam3X3 = "RANKED_TEAM_3x3";
        public const string RankedTeam5X5 = "RANKED_TEAM_5x5";
        public const string Normal3X3 = "NORMAL_3x3";
        public const string Bot3X3 = "BOT_3x3";
        public const string ARAMUnranked5X5 = "ARAM_UNRANKED_5x5";
        public const string OneForAll5X5 = "ONEFORALL_5x5";
        public const string FirstBlood1X1 = "FIRSTBLOOD_1x1";
        public const string FirstBlood2X2 = "FIRSTBLOOD_2x2";

        public static readonly Dictionary<GameSubTypeEnum, string> GameSubTypes = new Dictionary<GameSubTypeEnum, string>
        {
            { GameSubTypeEnum.None, None },
            { GameSubTypeEnum.Normal, Normal },
            { GameSubTypeEnum.Bot, Bot },
            { GameSubTypeEnum.RankedSolo5X5, RankedSolo5X5 },
            { GameSubTypeEnum.RankedPremade3X3, RankedPremade3X3 },
            { GameSubTypeEnum.RankedPremade5X5, RankedPremade5X5 },
            { GameSubTypeEnum.ODINUnranked, ODINUnranked },
            { GameSubTypeEnum.RankedTeam3X3, RankedTeam3X3 },
            { GameSubTypeEnum.RankedTeam5X5, RankedTeam5X5 },
            { GameSubTypeEnum.Normal3X3, Normal3X3 },
            { GameSubTypeEnum.Bot3X3, Bot3X3 },
            { GameSubTypeEnum.ARAMUnranked5X5, ARAMUnranked5X5 },
            { GameSubTypeEnum.OneForAll5X5, OneForAll5X5 },
            { GameSubTypeEnum.FirstBlood1X1, FirstBlood1X1 },
            { GameSubTypeEnum.FirstBlood2X2, FirstBlood2X2 },
        };
    }
}
