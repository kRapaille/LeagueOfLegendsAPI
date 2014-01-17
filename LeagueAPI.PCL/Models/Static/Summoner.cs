using System.Collections.Generic;
using Newtonsoft.Json;
using PortableLeagueAPI.Helpers;

namespace PortableLeagueAPI.Models.Static
{
    public class SummonerRootobject
    {
        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<string, Summoner> data { get; set; }
    }

    public class Summoner
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public int maxrank { get; set; }
        public int[] cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public int[] cost { get; set; }
        public string costBurn { get; set; }
        public object[] effect { get; set; }
        public object[] effectBurn { get; set; }
        public Var[] vars { get; set; }
        public string key { get; set; }
        public int summonerLevel { get; set; }
        public string[] modes { get; set; }
        public string costType { get; set; }
        public string range { get; set; }
        public string rangeBurn { get; set; }
        public Image image { get; set; }
        public string resource { get; set; }
    }
    public class Var
    {
        public string link { get; set; }

        [JsonConverter(typeof(OptionalArrayJsonConverter))]
        public float[] coeff { get; set; }
        public string key { get; set; }
    }

}
