namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IChampionStats
    {
        int ChampionId { get; set; }
        IAggregatedStats Stats { get; set; }
        string Name { get; set; }
    }
}