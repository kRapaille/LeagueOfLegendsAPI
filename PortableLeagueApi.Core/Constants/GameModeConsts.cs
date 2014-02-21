using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Constants
{
    public class GameModeConsts
    {
        public const string Classic = "CLASSIC";
        public const string Odin = "ODIN";
        public const string Aram = "ARAM";
        public const string Tutorial = "TUTORIAL";
        public const string OneForAll = "ONEFORALL";
        public const string FirstBlood = "FIRSTBLOOD";

        public static readonly Dictionary<GameModeEnum, string> GameModes = new Dictionary<GameModeEnum, string>
        {
            { GameModeEnum.Classic, Classic },
            { GameModeEnum.Odin, Odin },
            { GameModeEnum.Aram, Aram },
            { GameModeEnum.Tutorial, Tutorial },
            { GameModeEnum.OneForAll, OneForAll },
            { GameModeEnum.FirstBlood, FirstBlood },
        };
    }
}
