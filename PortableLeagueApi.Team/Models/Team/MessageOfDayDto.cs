using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.Team
{
    public class MessageOfDayDto
    {
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }
}