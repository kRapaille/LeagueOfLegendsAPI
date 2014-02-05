using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.Team
{
    public class MatchHistorySummaryDto
    {
        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("invalid")]
        public bool Invalid { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("opposingTeamKills")]
        public int OpposingTeamKills { get; set; }

        [JsonProperty("opposingTeamName")]
        public string OpposingTeamName { get; set; }

        [JsonProperty("win")]
        public bool Win { get; set; }
    }
}