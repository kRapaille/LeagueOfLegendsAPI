using System.Collections.Generic;

namespace PortableLeagueApi.Interfaces.League
{
    public interface ILeague
    {
        IList<ILeagueItem> LeagueItems { get; set; }
        string Name { get; set; }
        string ParticipantId { get; set; }
    }
}