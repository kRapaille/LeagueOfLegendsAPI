using System;
using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Game
{
    public interface IGame : ILeagueModel
    {
        int GameId { get; set; }
        IList<IPlayer> OtherPlayers { get; set; }
        GameTypeEnum GameType { get; set; }
        IList<int> SummonerSpells { get; set; }
        int TeamId { get; set; }
        IRawStats Stats { get; set; }
        GameModeEnum GameMode { get; set; }
        MapEnum Map { get; set; }
        int Level { get; set; }
        bool Invalid { get; set; }
        GameSubTypeEnum GameSubType { get; set; }
        int ChampionId { get; set; }
        DateTime CreateDate { get; set; }
    }
}