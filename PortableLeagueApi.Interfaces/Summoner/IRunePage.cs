using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IRunePage : IApiModel
    {
        /// <summary>
        /// Rune page Id.
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// List of rune slots associated with the rune page.
        /// </summary>
        IRuneSlot[] Slots { get; set; }
        /// <summary>
        /// Rune page name.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Indicates if the page is the current page.
        /// </summary>
        bool Current { get; set; }
    }
}