using System;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface IMessageOfDay : IApiModel
    {
        DateTime CreateDate { get; set; }
        string Message { get; set; }
        int Version { get; set; }
    }
}