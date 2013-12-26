using System;
using Newtonsoft.Json;

namespace LeagueAPI.PCL.Models
{
    public class RankedStats
    {
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        [JsonProperty("champions")]
        public RankedStatsChampion[] Champions { get; set; }

        [JsonProperty("modifyDateStr")]
        public string ModifyDateStr { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }

    public class RankedStatsChampion
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("stats")]
        public Stat[] Stats { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Stat
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("c")]
        public int C { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

}
