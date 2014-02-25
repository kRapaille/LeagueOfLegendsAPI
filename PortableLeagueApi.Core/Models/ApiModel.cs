using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Core.Models
{
    public abstract class ApiModel : IApiModel
    {
        public ILeagueApiConfiguration ApiConfiguration { get; set; }
    }
}
