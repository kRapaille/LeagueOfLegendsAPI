using Newtonsoft.Json;

namespace LeagueAPI.PCL.Models
{
    public class LeagueInfo
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("queue")]
        public string Queue { get; set; }

        [JsonProperty("entries")]
        public Entry[] Entries { get; set; }
    }

    public class Entry
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
        public int LastPlayed { get; set; }

        [JsonProperty("timeUntilDecay")]
        public int TimeUntilDecay { get; set; }
    }
}
