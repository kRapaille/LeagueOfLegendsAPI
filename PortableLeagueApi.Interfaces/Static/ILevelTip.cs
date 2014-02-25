using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static
{
    public interface ILevelTip : IApiModel
    {
        IList<string> Effect { get; set; }
        IList<string> Label { get; set; }
    }
}