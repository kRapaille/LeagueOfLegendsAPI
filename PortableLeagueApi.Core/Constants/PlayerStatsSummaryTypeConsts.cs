using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Constants
{
    public class PlayerStatsSummaryTypeConsts
    {
        public const string Unranked = "Unranked";
        public const string Unranked3X3 = "Unranked3x3";
        public const string OdinUnranked = "OdinUnranked";
        public const string AramUnranked5X5 = "AramUnranked5x5";
        public const string CoopVsAI = "CoopVsAI";
        public const string CoopVsAI3X3 = "CoopVsAI3x3";
        public const string RankedSolo5X5 = "RankedSolo5x5";
        public const string RankedTeam3X3 = "RankedTeam3x3";
        public const string RankedTeam5X5 = "RankedTeam5x5";
        public const string OneForAll5X5 = "OneForAll5x5";
        public const string FirstBlood1X1 = "FirstBlood1x1";
        public const string FirstBlood2X2 = "FirstBlood2x2";
        public const string SummonersRift6X6 = "SummonersRift6x6";

        public static readonly Dictionary<PlayerStatsSummaryTypeEnum, string> PlayerStatsSummaryTypes = new Dictionary<PlayerStatsSummaryTypeEnum, string>
        {
            { PlayerStatsSummaryTypeEnum.Unranked, Unranked },
            { PlayerStatsSummaryTypeEnum.Unranked3X3, Unranked3X3 },
            { PlayerStatsSummaryTypeEnum.OdinUnranked, OdinUnranked },
            { PlayerStatsSummaryTypeEnum.AramUnranked5X5, AramUnranked5X5 },
            { PlayerStatsSummaryTypeEnum.CoopVsAI, CoopVsAI },
            { PlayerStatsSummaryTypeEnum.CoopVsAI3X3, CoopVsAI3X3 },
            { PlayerStatsSummaryTypeEnum.RankedSolo5X5, RankedSolo5X5 },
            { PlayerStatsSummaryTypeEnum.RankedTeam3X3, RankedTeam3X3 },
            { PlayerStatsSummaryTypeEnum.RankedTeam5X5, RankedTeam5X5 },
            { PlayerStatsSummaryTypeEnum.OneForAll5X5, OneForAll5X5 },
            { PlayerStatsSummaryTypeEnum.FirstBlood1X1, FirstBlood1X1 },
            { PlayerStatsSummaryTypeEnum.FirstBlood2X2, FirstBlood2X2 },
            { PlayerStatsSummaryTypeEnum.SummonersRift6X6, SummonersRift6X6 }
        };
    }
}
