using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Mastery
{
    public interface IMasteryList : IApiModel
    {
        IDictionary<string, IMastery> Data { get; set; }
        IMasteryTree Tree { get; set; }
        string Type { get; set; }
        string Version { get; set; }
    }
}