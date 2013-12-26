using Newtonsoft.Json;

namespace LeagueAPI.PCL.Models.v2.rev1
{
    public class Team
    {
        [JsonProperty("teamStatSummary")]
        public TeamStatSummary TeamStatSummary { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("roster")]
        public Roster Roster { get; set; }

        [JsonProperty("lastGameDate")]
        public long LastGameDate { get; set; }

        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        [JsonProperty("teamId")]
        public TeamId TeamId { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("lastJoinDate")]
        public long LastJoinDate { get; set; }

        [JsonProperty("secondLastJoinDate")]
        public long SecondLastJoinDate { get; set; }

        [JsonProperty("matchHistory")]
        public MatchHistory[] MatchHistory { get; set; }

        [JsonProperty("lastJoinedRankedTeamQueueDate")]
        public long LastJoinedRankedTeamQueueDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("thirdLastJoinDate")]
        public long ThirdLastJoinDate { get; set; }

        [JsonProperty("createDate")]
        public long CreateDate { get; set; }
    }

    public class TeamStatSummary
    {
        [JsonProperty("teamStatDetails")]
        public TeamStatDetail[] TeamStatDetails { get; set; }

        [JsonProperty("teamId")]
        public TeamId TeamId { get; set; }
    }

    public class TeamStatDetail
    {
        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        [JsonProperty("teamId")]
        public TeamId TeamId { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }
    }

    public class TeamId
    {
        [JsonProperty("fullId")]
        public string FullId { get; set; }
    }

    public class Roster
    {
        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty("memberList")]
        public MemberList[] MemberList { get; set; }
    }

    public class MemberList
    {
        [JsonProperty("joinDate")]
        public long JoinDate { get; set; }

        [JsonProperty("inviteDate")]
        public long InviteDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("playerId")]
        public int PlayerId { get; set; }
    }

    public class MatchHistory
    {
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("opposingTeamName")]
        public string OpposingTeamName { get; set; }

        [JsonProperty("invalid")]
        public bool Invalid { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("win")]
        public bool Win { get; set; }

        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("opposingTeamKills")]
        public int OpposingTeamKills { get; set; }
    }
}
