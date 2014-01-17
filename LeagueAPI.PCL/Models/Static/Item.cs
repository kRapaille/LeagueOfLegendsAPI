using System.Collections.Generic;

namespace PortableLeagueAPI.Models.Static
{
    public class ItemRootObject
    {
        public string type { get; set; }
        public string version { get; set; }
        public Basic basic { get; set; }
        public Dictionary<string, Item> data { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string colloq { get; set; }
        public string plaintext { get; set; }
        public string[] into { get; set; }
        public Image image { get; set; }
        public Gold gold { get; set; }
        public string[] tags { get; set; }
        public Stats stats { get; set; }
    }
}
