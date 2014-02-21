namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IRankedStats
    {
        long ModifyDate { get; set; }
        IChampionStats[] Champions { get; set; }
        long SummonerId { get; set; }
    }
}