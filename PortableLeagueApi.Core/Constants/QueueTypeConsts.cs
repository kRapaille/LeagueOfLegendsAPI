using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Constants
{
    public class QueueTypeConsts
    {
        public const string Custom = "CUSTOM";
        public const string Normal5x5Blind = "NORMAL_5x5_BLIND";
        public const string Bot5X5 = "BOT_5x5";
        public const string Bot5X5Intro = "BOT_5x5_INTRO";
        public const string Bot5X5Beginner = "BOT_5x5_BEGINNER";
        public const string Bot5X5Intermediate = "BOT_5x5_INTERMEDIATE";
        public const string Normal3X3 = "NORMAL_3x3";
        public const string Normal5X5Draft = "NORMAL_5x5_DRAFT";
        public const string Odin5X5Blind = "ODIN_5x5_BLIND";
        public const string Odin5X5Draft = "ODIN_5x5_DRAFT";
        public const string BotOdin5X5 = "BOT_ODIN_5x5";
        public const string RankedSolo5X5 = "RANKED_SOLO_5x5";
        public const string RankedPremade3X3 = "RANKED_PREMADE_3x3";
        public const string RankedPremade5X5 = "RANKED_PREMADE_5x5";
        public const string RankedTeam3X3 = "RANKED_TEAM_3x3";
        public const string RankedTeam5X5 = "RANKED_TEAM_5x5";
        public const string BotTT3X3 = "BOT_TT_3x3";
        public const string GroupFinder5X5 = "GROUP_FINDER_5x5";
        public const string Aram5X5 = "ARAM_5x5";
        public const string Oneforall5X5 = "ONEFORALL_5x5";
        public const string FirstBlood1X1 = "FIRSTBLOOD_1x1";
        public const string FirstBlood2X2 = "FIRSTBLOOD_2x2";
        public const string SR6X6 = "SR_6x6";
        public const string Urf5X5 = "URF_5x5";
        public const string BotUrf5X5 = "BOT_URF_5x5";
        public const string NightmareBot5X5Rank1 = "NIGHTMARE_BOT_5x5_RANK1";
        public const string NightmareBot5X5Rank2 = "NIGHTMARE_BOT_5x5_RANK2";
        public const string NightmareBot5X5Rank5 = "NIGHTMARE_BOT_5x5_RANK5";
        public const string Ascension5X5 = "ASCENSION_5x5";

        public static readonly Dictionary<QueueTypeEnum, string> QueueTypes = new Dictionary<QueueTypeEnum, string>
        {
          { QueueTypeEnum.CUSTOM, Custom },
          { QueueTypeEnum.NORMAL_5x5_BLIND, Normal5x5Blind },
          { QueueTypeEnum.BOT_5x5, Bot5X5 },
          { QueueTypeEnum.BOT_5x5_INTRO, Bot5X5Intro },
          { QueueTypeEnum.BOT_5x5_BEGINNER, Bot5X5Beginner },
          { QueueTypeEnum.BOT_5x5_INTERMEDIATE, Bot5X5Intermediate },
          { QueueTypeEnum.NORMAL_3x3, Normal3X3 },
          { QueueTypeEnum.NORMAL_5x5_DRAFT, Normal5X5Draft },
          { QueueTypeEnum.ODIN_5x5_BLIND, Odin5X5Blind },
          { QueueTypeEnum.ODIN_5x5_DRAFT, Odin5X5Draft },
          { QueueTypeEnum.BOT_ODIN_5x5, BotOdin5X5 },
          { QueueTypeEnum.RANKED_SOLO_5x5, RankedSolo5X5 },
          { QueueTypeEnum.RANKED_PREMADE_3x3, RankedPremade3X3 },
          { QueueTypeEnum.RANKED_PREMADE_5x5, RankedPremade5X5 },
          { QueueTypeEnum.RANKED_TEAM_3x3, RankedTeam3X3 },
          { QueueTypeEnum.RANKED_TEAM_5x5, RankedTeam5X5 },
          { QueueTypeEnum.BOT_TT_3x3, BotTT3X3 },
          { QueueTypeEnum.GROUP_FINDER_5x5, GroupFinder5X5 },
          { QueueTypeEnum.ARAM_5x5, Aram5X5 },
          { QueueTypeEnum.ONEFORALL_5x5, Oneforall5X5 },
          { QueueTypeEnum.FIRSTBLOOD_1x1, FirstBlood1X1 },
          { QueueTypeEnum.FIRSTBLOOD_2x2, FirstBlood2X2 },
          { QueueTypeEnum.SR_6x6, SR6X6 },
          { QueueTypeEnum.URF_5x5, Urf5X5 },
          { QueueTypeEnum.BOT_URF_5x5, BotUrf5X5 },
          { QueueTypeEnum.NIGHTMARE_BOT_5x5_RANK1, NightmareBot5X5Rank1 },
          { QueueTypeEnum.NIGHTMARE_BOT_5x5_RANK2, NightmareBot5X5Rank2 },
          { QueueTypeEnum.NIGHTMARE_BOT_5x5_RANK5, NightmareBot5X5Rank5 },
          { QueueTypeEnum.ASCENSION_5x5, Ascension5X5 }
        };
    }
}
