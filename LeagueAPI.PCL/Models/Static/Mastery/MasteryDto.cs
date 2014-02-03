using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static.Mastery
{
    public class MasteryListDto
    {
        [JsonProperty("data")]
        public Dictionary<string, MasteryDto> Data { get; set; }

        [JsonProperty("tree")]
        public Dictionary<string, List<List<MasteryTreeDto>>> Tree { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class MasteryDto
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("image")]
        public ImageDto Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prereq")]
        public string Prereq { get; set; }

        [JsonProperty("ranks")]
        public int Ranks { get; set; }
    }
}
