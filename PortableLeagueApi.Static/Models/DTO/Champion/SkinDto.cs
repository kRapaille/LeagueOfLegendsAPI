using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Champion
{
    public class SkinDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }
    }
}
