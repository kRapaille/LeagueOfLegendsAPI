using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IRune : IHasRuneId
    {
        string Description { get; set; }
        string Name { get; set; }
        int Tier { get; set; }
    }
}