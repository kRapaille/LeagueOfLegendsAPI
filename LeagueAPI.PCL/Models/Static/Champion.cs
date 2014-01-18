using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static
{
    public class StaticChampionRoot
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, StaticChampion> Data { get; set; }
    }
    
    public class StaticChampion
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("partype")]
        public string Partype { get; set; }

        [JsonProperty("stats")]
        public ChampionStats Stats { get; set; }
    }

    public class Info
    {
        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("magic")]
        public int Magic { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }
    }

    public class ChampionStats
    {
        [JsonProperty("hp")]
        public float HP { get; set; }

        [JsonProperty("hpperlevel")]
        public float HPperLevel { get; set; }

        [JsonProperty("mp")]
        public float MP { get; set; }

        [JsonProperty("mpperlevel")]
        public float MPperLevel { get; set; }

        [JsonProperty("movespeed")]
        public float Movespeed { get; set; }

        [JsonProperty("armor")]
        public float Armor { get; set; }

        [JsonProperty("armorperlevel")]
        public float ArmorPerLevel { get; set; }

        [JsonProperty("spellblock")]
        public float Spellblock { get; set; }

        [JsonProperty("spellblockperlevel")]
        public float Spellblockperlevel { get; set; }

        [JsonProperty("attackrange")]
        public float Attackrange { get; set; }

        [JsonProperty("hpregen")]
        public float Hpregen { get; set; }

        [JsonProperty("hpregenperlevel")]
        public float Hpregenperlevel { get; set; }

        [JsonProperty("mpregen")]
        public float Mpregen { get; set; }

        [JsonProperty("mpregenperlevel")]
        public float Mpregenperlevel { get; set; }

        [JsonProperty("crit")]
        public float Crit { get; set; }

        [JsonProperty("critperlevel")]
        public float Critperlevel { get; set; }

        [JsonProperty("attackdamage")]
        public float Attackdamage { get; set; }

        [JsonProperty("attackdamageperlevel")]
        public float Attackdamageperlevel { get; set; }

        [JsonProperty("attackspeedoffset")]
        public float Attackspeedoffset { get; set; }

        [JsonProperty("attackspeedperlevel")]
        public float Attackspeedperlevel { get; set; }
    }
}
