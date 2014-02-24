namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IMasteryPage
    {
        long Id { get; set; }
        ITalent[] Talents { get; set; }
        string Name { get; set; }
        bool Current { get; set; }
    }
}