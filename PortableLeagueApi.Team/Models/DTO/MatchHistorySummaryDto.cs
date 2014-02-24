using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class MatchHistorySummaryDto
    {
        [JsonProperty("assists")]
        internal int Assists { get; set; }

        [JsonProperty("date")]
        internal long Date { get; set; }

        [JsonProperty("deaths")]
        internal int Deaths { get; set; }

        [JsonProperty("gameId")]
        internal int GameId { get; set; }

        [JsonProperty("gameMode")]
        internal string GameMode { get; set; }

        [JsonProperty("invalid")]
        internal bool Invalid { get; set; }

        [JsonProperty("kills")]
        internal int Kills { get; set; }

        [JsonProperty("mapId")]
        internal int MapId { get; set; }

        [JsonProperty("opposingTeamKills")]
        internal int OpposingTeamKills { get; set; }

        [JsonProperty("opposingTeamName")]
        internal string OpposingTeamName { get; set; }

        [JsonProperty("win")]
        internal bool Win { get; set; }
    }
}