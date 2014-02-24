namespace PortableLeagueApi.Interfaces.Team
{
    public interface ITeamStatDetail
    {
        int AverageGamesPlayed { get; set; }
        string FullId { get; set; }
        int Losses { get; set; }
        string TeamStatType { get; set; }
        int Wins { get; set; }
    }
}