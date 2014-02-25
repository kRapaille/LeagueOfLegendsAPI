using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IInfo : IApiModel
    {
        int Attack { get; set; }
        int Defense { get; set; }
        int Difficulty { get; set; }
        int Magic { get; set; }
    }
}