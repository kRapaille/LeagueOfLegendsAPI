using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Mastery
{
    public interface IMasteryTreeItem : IApiModel
    {
        int MasteryId { get; set; }
        string Prereq { get; set; }
    }
}