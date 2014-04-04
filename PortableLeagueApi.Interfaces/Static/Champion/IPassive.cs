using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IPassive : IApiModel
    {
        string Description { get; set; }
        string SanitizedDescription { get; set; }

        IImage Image { get; set; }
        string Name { get; set; }
    }
}