using System.Collections.Generic;

namespace PortableLeagueAPI.Models.Static
{
    public class MasteryRootobject
    {
        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<string, List<List<TreeItem>>> tree { get; set; }
        public Dictionary<string, Mastery> data { get; set; }
    }
    
    public class TreeItem
    {
        public string masteryId { get; set; }
        public string prereq { get; set; }
    }

    public class Mastery
    {
        public int id { get; set; }
        public string name { get; set; }
        public string[] description { get; set; }
        public Image image { get; set; }
        public int ranks { get; set; }
        public string prereq { get; set; }
    }
}
