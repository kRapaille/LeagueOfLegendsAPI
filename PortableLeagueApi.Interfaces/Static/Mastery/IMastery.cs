using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Mastery
{
    public interface IMastery : IApiModel
    {
        int Id { get; set; }
        IList<string> Description { get; set; }
        IImage Image { get; set; }
        string Name { get; set; }
        string Prereq { get; set; }
        int Ranks { get; set; }
    }
}