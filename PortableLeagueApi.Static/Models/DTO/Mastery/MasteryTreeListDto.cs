using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO.Mastery
{
    internal class MasteryTreeListDto
    {
        [JsonProperty("masteryTreeItems")]
        public IList<MasteryTreeItemDto> MasteryTreeItems { get; set; }
    }
}
