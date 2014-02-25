using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IBlock : IApiModel
    {
        IBlockItem[] Items { get; set; }
        string Type { get; set; }
    }
}