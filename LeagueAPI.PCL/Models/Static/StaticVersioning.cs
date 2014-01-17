using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static
{
    public class StaticVersioningRoot
    {
        [JsonProperty("n")]
        public StaticAPIVersions StaticAPIVersions { get; set; }

        [JsonProperty("v")]
        public string V { get; set; }

        [JsonProperty("l")]
        public string L { get; set; }

        [JsonProperty("cdn")]
        public string Cdn { get; set; }

        [JsonProperty("dd")]
        public string Dd { get; set; }

        [JsonProperty("lg")]
        public string Lg { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }

        [JsonProperty("profileiconmax")]
        public int Profileiconmax { get; set; }

        [JsonProperty("store")]
        public object Store { get; set; }
    }

    public class StaticAPIVersions
    {

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("rune")]
        public string Rune { get; set; }

        [JsonProperty("mastery")]
        public string Mastery { get; set; }

        [JsonProperty("summoner")]
        public string Summoner { get; set; }

        [JsonProperty("champion")]
        public string Champion { get; set; }

        [JsonProperty("profileicon")]
        public string Profileicon { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}
