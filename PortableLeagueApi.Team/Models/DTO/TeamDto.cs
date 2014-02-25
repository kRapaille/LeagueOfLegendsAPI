using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class TeamDto
    {
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }

        [JsonProperty("fullId")]
        public string FullId { get; set; }

        [JsonProperty("lastGameDate")]
        public long LastGameDate { get; set; }

        [JsonProperty("lastJoinDate")]
        public long LastJoinDate { get; set; }

        [JsonProperty("lastJoinedRankedTeamQueueDate")]
        public long LastJoinedRankedTeamQueueDate { get; set; }

        [JsonProperty("matchHistory")]
        public MatchHistorySummaryDto[] MatchHistory { get; set; }

        [JsonProperty("messageOfDay")]
        public MessageOfDayDto MessageOfDay { get; set; }

        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roster")]
        public RosterDto Roster { get; set; }

        [JsonProperty("secondLastJoinDate")]
        public long SecondLastJoinDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("teamStatSummary")]
        public TeamStatSummaryDto TeamStatSummary { get; set; }

        [JsonProperty("thirdLastJoinDate")]
        public long ThirdLastJoinDate { get; set; }
    }
}
