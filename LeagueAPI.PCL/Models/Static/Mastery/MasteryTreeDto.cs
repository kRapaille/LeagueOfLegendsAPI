using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static.Mastery
{
    public class MasteryTreeDto
    {
        [JsonProperty("Defense")]
        public object[] Defense { get; set; }

        [JsonProperty("Offense")]
        public object[] Offense { get; set; }

        [JsonProperty("Utility")]
        public object[] Utility { get; set; }
    }
}
