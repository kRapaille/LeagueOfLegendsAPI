using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Item
{
    public interface IMetaData : IApiModel
    {
        bool IsRune { get; set; }
        string Tier { get; set; }
        string Type { get; set; }
    }
}