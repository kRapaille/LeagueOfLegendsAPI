using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static
{
    public class MasteryRootobject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("tree")]
        public Dictionary<string, List<List<TreeItem>>> Tree { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, Mastery> Data { get; set; }
    }
    
    public class TreeItem
    {
        [JsonProperty("masteryId")]
        public string MasteryId { get; set; }

        [JsonProperty("prereq")]
        public string Prereq { get; set; }
    }

    public class Mastery
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("ranks")]
        public int Ranks { get; set; }

        [JsonProperty("prereq")]
        public string Prereq { get; set; }
    }
}
