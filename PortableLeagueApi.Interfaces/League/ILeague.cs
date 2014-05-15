using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.League
{
    public interface ILeague : IApiModel
    {
        IList<ILeagueEntry> LeagueItems { get; set; }
        string Name { get; set; }
        string ParticipantId { get; set; }
        LeagueTypeEnum LeagueType { get; set; }
        TierEnum Tier { get; set; }
    }
}