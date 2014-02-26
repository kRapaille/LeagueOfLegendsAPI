using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Extensions
{
    public interface IHasRuneId : IApiModel
    {
         int Id { get; set; }
    }
}