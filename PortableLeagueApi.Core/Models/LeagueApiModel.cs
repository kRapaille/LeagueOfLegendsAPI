using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Core.Models
{
    public abstract class LeagueApiModel : IApiModel
    {
        public ILeagueApiConfiguration ApiConfiguration { get; set; }
    }
}
