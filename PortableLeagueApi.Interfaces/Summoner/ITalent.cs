using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface ITalent : IHasMasteryId
    {
        /// <summary>
        /// Talent rank.
        /// </summary>
        int Rank { get; set; }
        /// <summary>
        /// Talent name.
        /// </summary>
        string Name { get; set; }
    }
}