using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Mastery
{
    public interface IMasteryTree : IApiModel
    {
        IList<IMasteryTreeList> Defense { get; set; }
        IList<IMasteryTreeList> Offense { get; set; }
        IList<IMasteryTreeList> Utility { get; set; }
    }
}