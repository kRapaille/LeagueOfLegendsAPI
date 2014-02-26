using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IBlockItem : IApiModel
    {
        string Id { get; set; }
        int Count { get; set; }
    }
}