using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Mastery
{
    internal class MasteryTreeItemDto
    {
        [JsonProperty("masteryId")]
        public string MasteryId { get; set; }

        [JsonProperty("prereq")]
        public string Prereq { get; set; }
    }
}
