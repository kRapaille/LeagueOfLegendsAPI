using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.League
{
    public interface IMiniSeries : ILeagueModel
    {
        string Progress { get; set; }
        int Target { get; set; }
        long TimeLeftToPlayInMs { get; set; }
        int Wins { get; set; }
        int Losses { get; set; }
    }
}