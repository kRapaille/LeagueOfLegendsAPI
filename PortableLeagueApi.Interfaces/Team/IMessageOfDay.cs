using System;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface IMessageOfDay : ILeagueModel
    {
        DateTime CreateDate { get; set; }
        string Message { get; set; }
        int Version { get; set; }
    }
}