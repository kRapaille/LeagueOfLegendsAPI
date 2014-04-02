using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class MasteryPagesDto
    {
        [JsonProperty("pages")]
        public MasteryPageDto[] Pages { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }

    internal class MasteryPageDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("masteries")]
        public MasteryDto[] Masteries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("current")]
        public bool Current { get; set; }
    }
}
