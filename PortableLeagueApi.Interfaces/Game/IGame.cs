using System;
using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Game
{
    public interface IGame : IHasChampionId, IHasSummonerSpells
    {
        /// <summary>
        /// Game ID.
        /// </summary>
        int GameId { get; set; }
        /// <summary>
        /// Other players associated with the game.
        /// </summary>
        IList<IPlayer> OtherPlayers { get; set; }
        /// <summary>
        /// Game type.
        /// </summary>
        GameTypeEnum GameType { get; set; }
        /// <summary>
        /// Team ID associated with game.
        /// </summary>
        int TeamId { get; set; }
        /// <summary>
        /// Statistics associated with the game for this summoner.
        /// </summary>
        IRawStats Stats { get; set; }
        /// <summary>
        /// Game mode.
        /// </summary>
        GameModeEnum GameMode { get; set; }
        /// <summary>
        /// Map.
        /// </summary>
        MapEnum Map { get; set; }
        /// <summary>
        /// Level.
        /// </summary>
        int Level { get; set; }
        /// <summary>
        /// Invalid flag.
        /// </summary>
        bool Invalid { get; set; }
        /// <summary>
        /// Game sub-type.
        /// </summary>
        GameSubTypeEnum GameSubType { get; set; }
        /// <summary>
        /// Date that end game data was recorded, specified as epoch milliseconds.
        /// </summary>
        DateTime CreateDate { get; set; }
    }
}