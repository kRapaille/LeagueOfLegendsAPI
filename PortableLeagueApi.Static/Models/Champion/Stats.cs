using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class Stats : ApiModel, IStats
    {
        public double Armor { get; set; }

        public double Armorperlevel { get; set; }

        public double Attackdamage { get; set; }

        public double Attackdamageperlevel { get; set; }

        public double Attackrange { get; set; }

        public double Attackspeedoffset { get; set; }

        public double Attackspeedperlevel { get; set; }
        
        public double Crit { get; set; }

        public double Critperlevel { get; set; }

        public double HP { get; set; }

        public double Hpperlevel { get; set; }

        public double Hpregen { get; set; }

        public double Hpregenperlevel { get; set; }

        public double Movespeed { get; set; }

        public double MP { get; set; }

        public double Mpperlevel { get; set; }

        public double Mpregen { get; set; }

        public double Mpregenperlevel { get; set; }
        
        public double Spellblock { get; set; }

        public double Spellblockperlevel { get; set; }

        public double AttackspeedBase
        {
            get { return 1 / (1.6 * (1 + Attackspeedoffset)); }
        }

        public double GetAttackSpeed(double attackSpeedBonus, int championLevel)
        {
            return AttackspeedBase*(1 + attackSpeedBonus + Attackspeedperlevel*(championLevel - 1)/100);
        }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<StatsDto, Stats, IStats>();
        }
    }
}