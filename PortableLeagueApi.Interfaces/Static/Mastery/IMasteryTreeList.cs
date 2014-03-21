using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Mastery
{
    public interface IMasteryTreeList : IApiModel
    {
        IList<IMasteryTreeItem> MasteryTreeItems { get; set; }
    }
}