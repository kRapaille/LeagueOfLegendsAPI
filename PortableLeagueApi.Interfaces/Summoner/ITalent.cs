namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface ITalent
    {
        int Id { get; set; }
        int Rank { get; set; }
        string Name { get; set; }
    }
}