using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Mastery
{
    internal class MasteryTreeDto
    {
        [JsonProperty("Defense")]
        public IList<MasteryTreeListDto> Defense { get; set; }

        [JsonProperty("Offense")]
        public IList<MasteryTreeListDto> Offense { get; set; }

        [JsonProperty("Utility")]
        public IList<MasteryTreeListDto> Utility { get; set; }
    }
}
