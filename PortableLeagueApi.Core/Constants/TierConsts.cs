using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Constants
{
    public class TierConsts 
    {
        public const string Bronze = "BRONZE";
        public const string Challenger = "CHALLENGER";
        public const string Diamond = "DIAMOND";
        public const string Gold = "GOLD";
        public const string Platinum = "PLATINUM";
        public const string Silver = "SILVER";

        public static readonly Dictionary<TierEnum, string> Tiers = new Dictionary<TierEnum, string>
        {
            { TierEnum.Bronze, Bronze },
            { TierEnum.Challenger, Challenger },
            { TierEnum.Diamond, Diamond },
            { TierEnum.Gold, Gold },
            { TierEnum.Platinum, Platinum },
            { TierEnum.Silver, Silver },
        };
    }
}
