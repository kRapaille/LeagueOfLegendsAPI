namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IRune
    {
        int Id { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        int Tier { get; set; }
    }
}