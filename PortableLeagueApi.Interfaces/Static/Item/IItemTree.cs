using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Item
{
    public interface IItemTree : IApiModel
    {
        string Header { get; set; }
        IList<string> Tags { get; set; }
    }
}