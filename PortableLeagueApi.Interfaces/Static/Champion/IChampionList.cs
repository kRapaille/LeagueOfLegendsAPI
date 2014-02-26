using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IChampionList : IApiModel
    {
        string Type { get; set; }

        string Format { get; set; }

        string Version { get; set; }

        IDictionary<string, string> Keys { get; set; }

        IDictionary<string, IChampion> Data { get; set; }
    }
}