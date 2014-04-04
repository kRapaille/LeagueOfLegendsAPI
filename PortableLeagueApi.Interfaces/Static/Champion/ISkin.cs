using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface ISkin : IApiModel
    {
        int Id { get; set; }
        string Name { get; set; }
        int Num { get; set; }
    }
}