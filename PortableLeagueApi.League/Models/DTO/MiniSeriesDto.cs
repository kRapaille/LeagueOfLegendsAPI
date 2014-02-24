using Newtonsoft.Json;

namespace PortableLeagueApi.League.Models.DTO
{
    internal class MiniSeriesDto
    {
        [JsonProperty("losses")]
        internal int Losses { get; set; }

        [JsonProperty("progress")]
        internal string Progress { get; set; }

        [JsonProperty("target")]
        internal int Target { get; set; }

        [JsonProperty("timeLeftToPlayMillis")]
        internal long TimeLeftToPlayMillis { get; set; }

        [JsonProperty("wins")]
        internal int Wins { get; set; }
    }
}