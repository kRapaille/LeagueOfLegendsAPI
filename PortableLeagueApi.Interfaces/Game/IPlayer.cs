using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Game
{
    public interface IPlayer : IHasSummonerId
    {
        /// <summary>
        /// Champion id associated with player.
        /// </summary>
        int ChampionId { get; set; }
        /// <summary>
        /// Team id associated with player.
        /// </summary>
        int TeamId { get; set; }
    }
}