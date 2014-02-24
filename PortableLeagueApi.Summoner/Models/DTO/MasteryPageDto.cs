using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class MasteryPagesDto
    {
        [JsonProperty("pages")]
        internal MasteryPageDto[] Pages { get; set; }

        [JsonProperty("summonerId")]
        internal long SummonerId { get; set; }
    }

    internal class MasteryPageDto
    {
        [JsonProperty("id")]
        internal long Id { get; set; }

        [JsonProperty("talents")]
        internal TalentDto[] Talents { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("current")]
        internal bool Current { get; set; }
    }
}
