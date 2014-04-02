using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Extensions
{
    public interface IHasRuneId : IApiModel
    {
         int RuneId { get; set; }
    }
}