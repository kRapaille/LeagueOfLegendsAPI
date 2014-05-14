using Newtonsoft.Json;

namespace PortableLeagueApi.League.Models.DTO
{
    internal class LeagueDto
    {
        [JsonProperty("entries")]
        public LeagueEntryDto[] Entries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// (legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)
        /// </summary>
        [JsonProperty("queue")]
        public string Queue { get; set; }

        /// <summary>
        /// (legal values: CHALLENGER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE)
        /// </summary>
        [JsonProperty("tier")]
        public string Tier { get; set; }
    }

    internal class LeagueEntryDto
    {
        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("isFreshBlood")]
        public bool IsFreshBlood { get; set; }

        [JsonProperty("isHotStreak")]
        public bool IsHotStreak { get; set; }

        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }

        [JsonProperty("isVeteran")]
        public bool IsVeteran { get; set; }

        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }

        [JsonProperty("miniSeries")]
        public MiniSeriesDto MiniSeries { get; set; }

        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }
        
        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}