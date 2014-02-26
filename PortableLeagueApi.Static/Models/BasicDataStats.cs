using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Static.Models.DTO;

namespace PortableLeagueApi.Static.Models
{
    public class BasicDataStats : ApiModel, IBasicDataStats
    {
        public double FlatArmorMod { get; set; }
        public double FlatAttackSpeedMod { get; set; }
        public double FlatBlockMod { get; set; }
        public double FlatCritChanceMod { get; set; }
        public double FlatCritDamageMod { get; set; }
        public double FlatEXPBonus { get; set; }
        public double FlatEnergyPoolMod { get; set; }
        public double FlatEnergyRegenMod { get; set; }
        public double FlatHPPoolMod { get; set; }
        public double FlatHPRegenMod { get; set; }
        public double FlatMPPoolMod { get; set; }
        public double FlatMPRegenMod { get; set; }
        public double FlatMagicDamageMod { get; set; }
        public double FlatMovementSpeedMod { get; set; }
        public double FlatPhysicalDamageMod { get; set; }
        public double FlatSpellBlockMod { get; set; }
        public double PercentArmorMod { get; set; }
        public double PercentAttackSpeedMod { get; set; }
        public double PercentBlockMod { get; set; }
        public double PercentCritChanceMod { get; set; }
        public double PercentCritDamageMod { get; set; }
        public double PercentDodgeMod { get; set; }
        public double PercentEXPBonus { get; set; }
        public double PercentHPPoolMod { get; set; }
        public double PercentHPRegenMod { get; set; }
        public double PercentLifeStealMod { get; set; }
        public double PercentMPPoolMod { get; set; }
        public double PercentMPRegenMod { get; set; }
        public double PercentMagicDamageMod { get; set; }
        public double PercentMovementSpeedMod { get; set; }
        public double PercentPhysicalDamageMod { get; set; }
        public double PercentSpellBlockMod { get; set; }
        public double PercentSpellVampMod { get; set; }
        public double RFlatArmorModPerLevel { get; set; }
        public double RFlatArmorPenetrationMod { get; set; }
        public double RFlatArmorPenetrationModPerLevel { get; set; }
        public double RFlatCritChanceModPerLevel { get; set; }
        public double RFlatCritDamageModPerLevel { get; set; }
        public double RFlatDodgeMod { get; set; }
        public double RFlatDodgeModPerLevel { get; set; }
        public double RFlatEnergyModPerLevel { get; set; }
        public double RFlatEnergyRegenModPerLevel { get; set; }
        public double RFlatGoldPer10Mod { get; set; }
        public double RFlatHPModPerLevel { get; set; }
        public double RFlatHPRegenModPerLevel { get; set; }
        public double RFlatMPeModPerLevel { get; set; }
        public double RFlatMPRegenModPerLevel { get; set; }
        public double RFlatMagicDamageModPerLevel { get; set; }
        public double RFlatMagicPenetrationMod { get; set; }
        public double RFlatMagicPenetrationModPerLevel { get; set; }
        public double RFlatMovementSpeedModPerLevel { get; set; }
        public double RFlatPhysicalDamageModPerLevel { get; set; }
        public double RFlatSpellBlockModPerLevel { get; set; }
        public double RFlatTimeDeadMod { get; set; }
        public double RFlatTimeDeadModPerLevel { get; set; }
        public double RPercentArmorPenetrationMod { get; set; }
        public double RPercentArmorPenetrationModPerLevel { get; set; }
        public double RPercentAttackSpeedModPerLevel { get; set; }
        public double RPercentCooldownMod { get; set; }
        public double RPercentCooldownModPerLevel { get; set; }
        public double RPercentMagicPenetrationMod { get; set; }
        public double RPercentMagicPenetrationModPerLevel { get; set; }
        public double RPercentMovementSpeedModPerLevel { get; set; }
        public double RPercentTimeDeadMod { get; set; }
        public double RPercentTimeDeadModPerLevel { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<BasicDataStatsDto, BasicDataStats, IBasicDataStats>();
        }
    }
}
