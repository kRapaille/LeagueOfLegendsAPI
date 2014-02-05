﻿using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.Static.Champion
{
    public class SkinDto
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }
    }
}