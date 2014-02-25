using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class MessageOfDayDto
    {
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }
}