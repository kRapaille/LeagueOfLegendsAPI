using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IChampionList : IApiModel
    {
        string Type { get; set; }

        string Format { get; set; }

        string Version { get; set; }

        Dictionary<string, string> Keys { get; set; }

        Dictionary<string, IChampion> Data { get; set; }
    }
}