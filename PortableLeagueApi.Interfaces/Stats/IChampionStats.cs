using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IChampionStats : IHasChampionId
    {
        /// <summary>
        /// Aggregated stats associated with the champion.
        /// </summary>
        IAggregatedStats Stats { get; set; }
        /// <summary>
        /// Champion name.
        /// </summary>
        string Name { get; set; }
    }
}