using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.League
{
    public class League
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// (legal values: CHALLENGER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE)
        /// </summary>
        [JsonProperty("tier")]
        public string Tier { get; set; }

        /// <summary>
        /// (legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)
        /// </summary>
        [JsonProperty("queue")]
        public string Queue { get; set; }

        [JsonProperty("entries")]
        public LeagueItem[] LeagueItems { get; set; }
    }

    public class LeagueItem
    {
        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        [JsonProperty("leagueName")]
        public string LeagueName { get; set; }

        [JsonProperty("queueType")]
        public string QueueType { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("isHotStreak")]
        public bool IsHotStreak { get; set; }

        [JsonProperty("isVeteran")]
        public bool IsVeteran { get; set; }

        [JsonProperty("isFreshBlood")]
        public bool IsFreshBlood { get; set; }

        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }

        [JsonProperty("lastPlayed")]
        public long LastPlayed { get; set; }

        [JsonProperty("timeUntilDecay")]
        public long TimeUntilDecay { get; set; }

        [JsonProperty("miniSeries")]
        public MiniSeries MiniSeries { get; set; }
    }

    public class MiniSeries
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