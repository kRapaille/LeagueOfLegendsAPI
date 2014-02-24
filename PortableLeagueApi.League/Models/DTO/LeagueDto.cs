using Newtonsoft.Json;

namespace PortableLeagueApi.League.Models.DTO
{
    internal class LeagueDto
    {
        [JsonProperty("entries")]
        internal LeagueItemDto[] Entries { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("participantId")]
        internal string ParticipantId { get; set; }

        /// <summary>
        /// (legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)
        /// </summary>
        [JsonProperty("queue")]
        internal string Queue { get; set; }

        /// <summary>
        /// (legal values: CHALLENGER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE)
        /// </summary>
        [JsonProperty("tier")]
        internal string Tier { get; set; }
    }

    internal class LeagueItemDto
    {
        [JsonProperty("isFreshBlood")]
        internal bool IsFreshBlood { get; set; }

        [JsonProperty("isHotStreak")]
        internal bool IsHotStreak { get; set; }

        [JsonProperty("isInactive")]
        internal bool IsInactive { get; set; }

        [JsonProperty("isVeteran")]
        internal bool IsVeteran { get; set; }

        [JsonProperty("lastPlayed")]
        internal long LastPlayed { get; set; }

        [JsonProperty("leagueName")]
        internal string LeagueName { get; set; }

        [JsonProperty("leaguePoints")]
        internal int LeaguePoints { get; set; }

        [JsonProperty("miniSeries")]
        internal MiniSeriesDto MiniSeries { get; set; }

        [JsonProperty("playerOrTeamId")]
        internal string PlayerOrTeamId { get; set; }
        
        [JsonProperty("playerOrTeamName")]
        internal string PlayerOrTeamName { get; set; }

        [JsonProperty("queueType")]
        internal string QueueType { get; set; }

        [JsonProperty("rank")]
        internal string Rank { get; set; }

        [JsonProperty("tier")]
        internal string Tier { get; set; }

        [JsonProperty("wins")]
        internal int Wins { get; set; }
    }
}