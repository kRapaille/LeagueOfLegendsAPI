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
        public const string RankedPremade3X3 = "RankedPremade3x3";
        public const string RankedPremade5X5 = "RankedPremade5x5";
        public const string OneForAll5X5 = "OneForAll5x5";
        public const string FirstBlood1X1 = "FirstBlood1x1";
        public const string FirstBlood2X2 = "FirstBlood2x2";
        public const string SummonersRift6X6 = "SummonersRift6x6";
        public const string CAP5X5 = "CAP5x5";
        public const string Urf = "URF";
        public const string UrfBot = "URFBots";
        public const string Ascension = "Ascension";
        public const string Hexakill = "Hexakill";
        public const string NightmareBot = "NightmareBot";

        public static readonly Dictionary<PlayerStatSummaryTypeEnum, string> PlayerStatsSummaryTypes = new Dictionary<PlayerStatSummaryTypeEnum, string>
        {
            { PlayerStatSummaryTypeEnum.Unranked, Unranked },
            { PlayerStatSummaryTypeEnum.Unranked3X3, Unranked3X3 },
            { PlayerStatSummaryTypeEnum.OdinUnranked, OdinUnranked },
            { PlayerStatSummaryTypeEnum.AramUnranked5X5, AramUnranked5X5 },
            { PlayerStatSummaryTypeEnum.CoopVsAI, CoopVsAI },
            { PlayerStatSummaryTypeEnum.CoopVsAI3X3, CoopVsAI3X3 },
            { PlayerStatSummaryTypeEnum.RankedSolo5X5, RankedSolo5X5 },
            { PlayerStatSummaryTypeEnum.RankedTeam3X3, RankedTeam3X3 },
            { PlayerStatSummaryTypeEnum.RankedTeam5X5, RankedTeam5X5 },
            { PlayerStatSummaryTypeEnum.RankedPremade3X3, RankedPremade3X3 },
            { PlayerStatSummaryTypeEnum.RankedPremade5X5, RankedPremade5X5 },
            { PlayerStatSummaryTypeEnum.OneForAll5X5, OneForAll5X5 },
            { PlayerStatSummaryTypeEnum.FirstBlood1X1, FirstBlood1X1 },
            { PlayerStatSummaryTypeEnum.FirstBlood2X2, FirstBlood2X2 },
            { PlayerStatSummaryTypeEnum.SummonersRift6X6, SummonersRift6X6 },
            { PlayerStatSummaryTypeEnum.CAP5X5, CAP5X5 },
            { PlayerStatSummaryTypeEnum.Urf, Urf },
            { PlayerStatSummaryTypeEnum.UrfBot, UrfBot },
            { PlayerStatSummaryTypeEnum.Ascension, Ascension },
            { PlayerStatSummaryTypeEnum.Hexakill, Hexakill },
            { PlayerStatSummaryTypeEnum.NightmareBot, NightmareBot }
        };
    }
}
