using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IRuneSlot : IHasRuneId
    {
        /// <summary>
        /// Rune slot Id.
        /// </summary>
        int RuneSlotId { get; set; }
    }
}