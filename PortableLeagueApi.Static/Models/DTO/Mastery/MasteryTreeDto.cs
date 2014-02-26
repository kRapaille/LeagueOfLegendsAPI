using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Mastery
{
    internal class MasteryTreeDto
    {
        [JsonProperty("Defense")]
        public object[] Defense { get; set; }

        [JsonProperty("Offense")]
        public object[] Offense { get; set; }

        [JsonProperty("Utility")]
        public object[] Utility { get; set; }
    }
}
