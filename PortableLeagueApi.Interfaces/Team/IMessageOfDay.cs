using System;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface IMessageOfDay
    {
        DateTime CreateDate { get; set; }
        string Message { get; set; }
        int Version { get; set; }
    }
}