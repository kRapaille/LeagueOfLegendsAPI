using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IRune : ILeagueModel
    {
        int Id { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        int Tier { get; set; }
    }
}