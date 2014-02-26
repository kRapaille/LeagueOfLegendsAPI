using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Extensions
{
    public interface IHasChampionId : IApiModel
    {
        /// <summary>
        /// Champion Id.
        /// </summary>
        int ChampionId { get; set; }  
    }
}