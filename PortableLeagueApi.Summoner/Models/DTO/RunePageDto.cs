using Newtonsoft.Json;

namespace PortableLeagueApi.Summoner.Models.DTO
{
    internal class RunePagesDto
    {
        [JsonProperty("pages")]
        internal RunePageDto[] Pages { get; set; }

        [JsonProperty("summonerId")]
        internal long SummonerId { get; set; }
    }

    internal class RunePageDto
    {
        [JsonProperty("id")]
        internal int Id { get; set; }

        [JsonProperty("slots")]
        internal RuneSlotDto[] Slots { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("current")]
        internal bool Current { get; set; }
    }
}
