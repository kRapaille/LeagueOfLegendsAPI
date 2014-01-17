using System.Collections.Generic;

namespace PortableLeagueAPI.Models.Static
{
    public class LanguageRoot
    {
        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<string, string> data { get; set; }

        public Tree tree { get; set; }
    }

    
    public class Tree
    {
        public string searchKeyIgnore { get; set; }
        public object[] searchKeyRemap { get; set; }
    }
}
