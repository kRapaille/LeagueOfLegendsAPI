using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Constants
{
    public class GameTypeConsts
    {
        public const string CustomGame = "CUSTOM_GAME";
        public const string MatchedGame = "MATCHED_GAME";
        public const string TutorialGame = "TUTORIAL_GAME";

        public static readonly Dictionary<GameTypeEnum, string> GameTypes = new Dictionary<GameTypeEnum, string>
        {
            { GameTypeEnum.CustomGame, CustomGame },
            { GameTypeEnum.MatchedGame, MatchedGame },
            { GameTypeEnum.TutorialGame, TutorialGame }
        };
    }
}
