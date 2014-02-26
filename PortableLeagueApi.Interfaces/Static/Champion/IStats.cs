using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Champion
{
    public interface IStats : IApiModel
    {
        double Armor { get; set; }
        double Armorperlevel { get; set; }
        double Attackdamage { get; set; }
        double Attackdamageperlevel { get; set; }
        double Attackrange { get; set; }
        double Attackspeedoffset { get; set; }
        double Attackspeedperlevel { get; set; }
        double Crit { get; set; }
        double Critperlevel { get; set; }
        double HP { get; set; }
        double Hpperlevel { get; set; }
        double Hpregen { get; set; }
        double Hpregenperlevel { get; set; }
        double Movespeed { get; set; }
        double MP { get; set; }
        double Mpperlevel { get; set; }
        double Mpregen { get; set; }
        double Mpregenperlevel { get; set; }
        double Spellblock { get; set; }
        double Spellblockperlevel { get; set; }
    }
}