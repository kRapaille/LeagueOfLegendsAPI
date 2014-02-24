using System.Collections.Generic;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface ITeamStatSummary
    {
        string FullId { get; set; }
        IList<ITeamStatDetail> TeamStatDetails { get; set; }
    }
}