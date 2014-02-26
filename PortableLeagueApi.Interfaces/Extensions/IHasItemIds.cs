using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Extensions
{
    public interface IHasItemIds : IApiModel
    {
        IList<int> ItemIds { get; set; }
    }
}