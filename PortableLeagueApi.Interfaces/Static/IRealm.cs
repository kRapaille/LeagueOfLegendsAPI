using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static
{
    public interface IRealm : IApiModel
    {
        /// <summary>
        /// The base CDN url.
        /// </summary>
        string BaseCdnUrl { get; set; }

        /// <summary>
        /// Latest changed version of Dragon Magic's css file.
        /// </summary>
        string LatestChangedCssVersion { get; set; }

        /// <summary>
        /// Latest changed version of Dragon Magic.
        /// </summary>
        string LatestChangedDragonMagicVersion { get; set; }

        /// <summary>
        /// Default language for this realm.
        /// </summary>
        string DefaultLanguage { get; set; }

        /// <summary>
        /// Legacy script mode for IE6 or older.
        /// </summary>
        string LegacyScript { get; set; }

        /// <summary>
        /// Latest changed version for each data type listed.
        /// </summary>
        IDictionary<string, string> LatestChangedVersionForEachDataType { get; set; }

        /// <summary>
        /// Special behavior number identifying the largest profileicon id that can be used under 500. Any profileicon that is requested between this number and 500 should be mapped to 0.
        /// </summary>
        int ProfileIconMax { get; set; }

        /// <summary>
        /// Additional api data drawn from other sources that may be related to data dragon functionality.
        /// </summary>
        object Store { get; set; }

        /// <summary>
        /// Current version of this file for this realm.
        /// </summary>
        string CurrentVersion { get; set; }
    }
}