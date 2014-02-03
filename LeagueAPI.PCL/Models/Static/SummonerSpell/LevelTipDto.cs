using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static.SummonerSpell
{
    public class LevelTipDto
    {
        [JsonProperty("effect")]
        public string[] Effect { get; set; }

        [JsonProperty("label")]
        public string[] Label { get; set; }
    }
}
