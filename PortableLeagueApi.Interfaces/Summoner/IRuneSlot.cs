namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IRuneSlot
    {
        int RuneSlotId { get; set; }
        IRune Rune { get; set; }
    }
}