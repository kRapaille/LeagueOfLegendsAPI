using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Game
{
    public interface IPlayer : IHasSummonerId, IHasChampionId
    {
        /// <summary>
        /// Team id associated with player.
        /// </summary>
        int TeamId { get; set; }
    }
}