using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Game
{
    public interface IPlayer : ILeagueModel
    {
        int ChampionId { get; set; }
        int TeamId { get; set; }
        long SummonerId { get; set; }
    }
}