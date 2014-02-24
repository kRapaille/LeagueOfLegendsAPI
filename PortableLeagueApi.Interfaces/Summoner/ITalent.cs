using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface ITalent : ILeagueModel
    {
        /// <summary>
        /// Talent id.
        /// </summary>
        int Id { get; set; }
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