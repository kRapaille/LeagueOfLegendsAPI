using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface ITeamStatSummary : IApiModel
    {
        string FullId { get; set; }
        IList<ITeamStatDetail> TeamStatDetails { get; set; }
    }
}