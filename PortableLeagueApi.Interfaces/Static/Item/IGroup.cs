using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Item
{
    public interface IGroup : IApiModel
    {
        string MaxGroupOwnable { get; set; }
        string Key { get; set; }
    }
}