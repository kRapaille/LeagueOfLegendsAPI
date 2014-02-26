using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.DTO
{
    internal class GoldDto
    {
        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }

        [JsonProperty("sell")]
        public int Sell { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
