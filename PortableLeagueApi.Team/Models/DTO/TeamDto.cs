using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class TeamDto
    {
        [JsonProperty("createDate")]
        internal long CreateDate { get; set; }

        [JsonProperty("fullId")]
        internal string FullId { get; set; }

        [JsonProperty("lastGameDate")]
        internal long LastGameDate { get; set; }

        [JsonProperty("lastJoinDate")]
        internal long LastJoinDate { get; set; }

        [JsonProperty("lastJoinedRankedTeamQueueDate")]
        internal long LastJoinedRankedTeamQueueDate { get; set; }

        [JsonProperty("matchHistory")]
        internal MatchHistorySummaryDto[] MatchHistory { get; set; }

        [JsonProperty("messageOfDay")]
        internal MessageOfDayDto MessageOfDay { get; set; }

        [JsonProperty("modifyDate")]
        internal long ModifyDate { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("roster")]
        internal RosterDto Roster { get; set; }

        [JsonProperty("secondLastJoinDate")]
        internal long SecondLastJoinDate { get; set; }

        [JsonProperty("status")]
        internal string Status { get; set; }

        [JsonProperty("tag")]
        internal string Tag { get; set; }

        [JsonProperty("teamStatSummary")]
        internal TeamStatSummaryDto TeamStatSummary { get; set; }

        [JsonProperty("thirdLastJoinDate")]
        internal long ThirdLastJoinDate { get; set; }
    }
}
