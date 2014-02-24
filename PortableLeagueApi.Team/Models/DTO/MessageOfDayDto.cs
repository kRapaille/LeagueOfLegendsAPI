using Newtonsoft.Json;

namespace PortableLeagueApi.Team.Models.DTO
{
    internal class MessageOfDayDto
    {
        [JsonProperty("createDate")]
        internal long CreateDate { get; set; }

        [JsonProperty("message")]
        internal string Message { get; set; }

        [JsonProperty("version")]
        internal int Version { get; set; }
    }
}