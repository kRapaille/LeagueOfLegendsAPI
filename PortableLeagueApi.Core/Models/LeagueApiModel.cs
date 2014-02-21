using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Core.Models
{
    public abstract class LeagueApiModel : ILeagueModel
    {
        public ILeagueAPI Source { get; set; }
    }
}
