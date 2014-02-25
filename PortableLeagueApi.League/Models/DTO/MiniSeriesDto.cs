using Newtonsoft.Json;

namespace PortableLeagueApi.League.Models.DTO
{
    internal class MiniSeriesDto
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