using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Extensions
{
    public interface IHasSummonerId : IApiModel
    {
        /// <summary>
        /// Summoner Id.
        /// </summary>
        long SummonerId { get; set; } 
    }
}