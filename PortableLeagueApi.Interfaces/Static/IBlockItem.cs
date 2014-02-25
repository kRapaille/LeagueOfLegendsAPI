using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static
{
    public interface IBlockItem : IApiModel
    {
        string Id { get; set; }
        int Count { get; set; }
    }
}