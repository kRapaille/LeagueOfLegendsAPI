using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IMasteryPage : IApiModel
    {
        /// <summary>
        /// Mastery page Id.
        /// </summary>
        long Id { get; set; }
        /// <summary>
        /// Collection of masteries associated with the mastery page. For static information correlating to masteries, please refer to the LoL Static Data API.
        /// </summary>
        IList<IMastery> Masteries { get; set; }
        /// <summary>
        /// Mastery page name.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Indicates if the mastery page is the current mastery page.
        /// </summary>
        bool Current { get; set; }
    }
}