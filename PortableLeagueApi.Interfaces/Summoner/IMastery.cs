using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IMastery : IHasMasteryId
    {
        /// <summary>
        /// Talent rank.
        /// </summary>
        int Rank { get; set; }
    }
}