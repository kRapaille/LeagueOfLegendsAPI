using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class RunePagesDto
    {
        [JsonProperty("pages")]
        public RunePageDto[] Pages { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }

    internal class RunePageDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slots")]
        public RuneSlotDto[] Slots { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("current")]
        public bool Current { get; set; }
    }
}
