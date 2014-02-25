using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static
{
    public interface IImage : IApiModel
    {
        string Full { get; set; }
        string Group { get; set; }
        string Sprite { get; set; }
        int Height { get; set; }
        int Width { get; set; }
        int X { get; set; }
        int Y { get; set; }
    }
}