using System.Collections.Generic;

namespace PortableLeagueAPI.Models.Static
{
    public class RuneRootObject
    {
        public string type { get; set; }
        public string version { get; set; }
        public Basic basic { get; set; }
        public Dictionary<string, RuneItem> data { get; set; }
    }

    public class RuneItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public Image image { get; set; }
        public Rune rune { get; set; }
        public Stats stats { get; set; }
        public string[] tags { get; set; }
        public string colloq { get; set; }
        public object plaintext { get; set; }
    }
}
