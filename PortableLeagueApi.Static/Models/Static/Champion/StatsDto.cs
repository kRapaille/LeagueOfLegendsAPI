using Newtonsoft.Json;

namespace PortableLeagueApi.Static.Models.Static.Champion
{
    public class StatsDto
    {
        [JsonProperty("armor")]
        public double Armor { get; set; }

        [JsonProperty("armorperlevel")]
        public double Armorperlevel { get; set; }

        [JsonProperty("attackdamage")]
        public double Attackdamage { get; set; }

        [JsonProperty("attackdamageperlevel")]
        public double Attackdamageperlevel { get; set; }

        [JsonProperty("attackrange")]
        public double Attackrange { get; set; }

        [JsonProperty("attackspeedoffset")]
        public double Attackspeedoffset { get; set; }

        [JsonProperty("attackspeedperlevel")]
        public double Attackspeedperlevel { get; set; }

        [JsonProperty("crit")]
        public double Crit { get; set; }

        [JsonProperty("critperlevel")]
        public double Critperlevel { get; set; }

        [JsonProperty("hp")]
        public double HP { get; set; }

        [JsonProperty("hpperlevel")]
        public double Hpperlevel { get; set; }

        [JsonProperty("hpregen")]
        public double Hpregen { get; set; }

        [JsonProperty("hpregenperlevel")]
        public double Hpregenperlevel { get; set; }

        [JsonProperty("movespeed")]
        public double Movespeed { get; set; }

        [JsonProperty("mp")]
        public double MP { get; set; }

        [JsonProperty("mpperlevel")]
        public double Mpperlevel { get; set; }

        [JsonProperty("mpregen")]
        public double Mpregen { get; set; }

        [JsonProperty("mpregenperlevel")]
        public double Mpregenperlevel { get; set; }

        [JsonProperty("spellblock")]
        public double Spellblock { get; set; }

        [JsonProperty("spellblockperlevel")]
        public double Spellblockperlevel { get; set; }
    }
}
