using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IChampionStats : IApiModel
    {
        /// <summary>
        /// Champion id.
        /// </summary>
        int ChampionId { get; set; }
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