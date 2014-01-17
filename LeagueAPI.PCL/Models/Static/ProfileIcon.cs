using System.Collections.Generic;

namespace PortableLeagueAPI.Models.Static
{
    public class ProfileIconRoot
    {
        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<int, ProfileIcon> data { get; set; }
    }

    public class ProfileIcon
    {
        public int id { get; set; }
        public Image image { get; set; }
    }
}
