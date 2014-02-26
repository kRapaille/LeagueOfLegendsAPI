using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static
{
    public interface IItemRune : IApiModel
    {
        bool IsRune { get; set; }
        int Tier { get; set; }
        string Type { get; set; }
    }
}