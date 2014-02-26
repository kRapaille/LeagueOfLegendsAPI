using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static
{
    public interface IGold : IApiModel
    {
        int Base { get; set; }
        bool Purchasable { get; set; }
        int Sell { get; set; }
        int Total { get; set; }
    }
}