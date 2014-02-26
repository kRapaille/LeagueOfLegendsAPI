using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Item
{
    public interface IItemList : IApiModel
    {
        IBasicData Basic { get; set; }
        IDictionary<string, IItem> Data { get; set; }
        IList<IGroup> Groups { get; set; }
        IList<IItemTree> Tree { get; set; }
        string Type { get; set; }
        string Version { get; set; }
    }
}