using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.League
{
    public class MiniSeriesDto
    {
        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("target")]
        public int Target { get; set; }

        [JsonProperty("timeLeftToPlayMillis")]
        public long TimeLeftToPlayMillis { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}