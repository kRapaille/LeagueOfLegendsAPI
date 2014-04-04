using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IBlockItem : IApiModel
    {
        int Id { get; set; }
        int Count { get; set; }
    }
}