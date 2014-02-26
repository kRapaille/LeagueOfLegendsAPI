using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IRecommended : IApiModel
    {
        IList<IBlock> Blocks { get; set; }
        string Champion { get; set; }
        string Map { get; set; }
        string Mode { get; set; }
        bool Priority { get; set; }
        string Title { get; set; }
        string Type { get; set; }
    }
}