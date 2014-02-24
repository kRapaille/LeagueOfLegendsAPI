using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IRuneSlot : ILeagueModel
    {
        /// <summary>
        /// Rune slot Id.
        /// </summary>
        int RuneSlotId { get; set; }
        /// <summary>
        /// Rune associated with the rune slot.
        /// </summary>
        IRune Rune { get; set; }
    }
}