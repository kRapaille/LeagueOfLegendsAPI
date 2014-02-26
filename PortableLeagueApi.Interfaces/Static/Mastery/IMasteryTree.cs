using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Mastery
{
    public interface IMasteryTree : IApiModel
    {
        IList<object> Defense { get; set; }
        IList<object> Offense { get; set; }
        IList<object> Utility { get; set; }
    }
}