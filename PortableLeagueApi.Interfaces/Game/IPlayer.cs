using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Game
{
    public interface IPlayer : ILeagueModel
    {
        /// <summary>
        /// Champion id associated with player.
        /// </summary>
        int ChampionId { get; set; }
        /// <summary>
        /// Team id associated with player.
        /// </summary>
        int TeamId { get; set; }
        /// <summary>
        /// Summoner id associated with player.
        /// </summary>
        long SummonerId { get; set; }
    }
}