using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Extensions
{
    public interface IHasMasteryId : IApiModel
    {
        /// <summary>
        /// Talent id.
        /// </summary>
         int Id { get; set; }
    }
}