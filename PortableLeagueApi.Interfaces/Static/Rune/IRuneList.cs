using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Rune
{
    public interface IRuneList : IApiModel
    {
        IBasicData Basic { get; set; }
        IDictionary<string, IRune> Data { get; set; }
        string Type { get; set; }
        string Version { get; set; }
    }
}