namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IRunePage
    {
        int Id { get; set; }
        IRuneSlot[] Slots { get; set; }
        string Name { get; set; }
        bool Current { get; set; }
    }
}