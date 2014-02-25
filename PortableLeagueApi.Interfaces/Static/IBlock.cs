using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static
{
    public interface IBlock : IApiModel
    {
        IBlockItem[] Items { get; set; }
        string Type { get; set; }
    }
}