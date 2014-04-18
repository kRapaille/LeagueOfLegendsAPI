using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IBlock : IApiModel
    {
        IList<IBlockItem> Items { get; set; }
        string Type { get; set; }
        bool RecMath { get; set; }
    }
}