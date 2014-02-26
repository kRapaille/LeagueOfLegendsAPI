using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Rune
{
    public interface IRuneType : IApiModel
    {
        bool Isrune { get; set; }
        string Tier { get; set; }
        string Type { get; set; }
    }
}