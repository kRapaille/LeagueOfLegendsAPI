using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static
{
    public interface IBasicDataStats : IApiModel
    {
        double FlatArmorMod { get; set; }
        double FlatAttackSpeedMod { get; set; }
        double FlatBlockMod { get; set; }
        double FlatCritChanceMod { get; set; }
        double FlatCritDamageMod { get; set; }
        double FlatEXPBonus { get; set; }
        double FlatEnergyPoolMod { get; set; }
        double FlatEnergyRegenMod { get; set; }
        double FlatHPPoolMod { get; set; }
        double FlatHPRegenMod { get; set; }
        double FlatMPPoolMod { get; set; }
        double FlatMPRegenMod { get; set; }
        double FlatMagicDamageMod { get; set; }
        double FlatMovementSpeedMod { get; set; }
        double FlatPhysicalDamageMod { get; set; }
        double FlatSpellBlockMod { get; set; }
        double PercentArmorMod { get; set; }
        double PercentAttackSpeedMod { get; set; }
        double PercentBlockMod { get; set; }
        double PercentCritChanceMod { get; set; }
        double PercentCritDamageMod { get; set; }
        double PercentDodgeMod { get; set; }
        double PercentEXPBonus { get; set; }
        double PercentHPPoolMod { get; set; }
        double PercentHPRegenMod { get; set; }
        double PercentLifeStealMod { get; set; }
        double PercentMPPoolMod { get; set; }
        double PercentMPRegenMod { get; set; }
        double PercentMagicDamageMod { get; set; }
        double PercentMovementSpeedMod { get; set; }
        double PercentPhysicalDamageMod { get; set; }
        double PercentSpellBlockMod { get; set; }
        double PercentSpellVampMod { get; set; }
        double RFlatArmorModPerLevel { get; set; }
        double RFlatArmorPenetrationMod { get; set; }
        double RFlatArmorPenetrationModPerLevel { get; set; }
        double RFlatCritChanceModPerLevel { get; set; }
        double RFlatCritDamageModPerLevel { get; set; }
        double RFlatDodgeMod { get; set; }
        double RFlatDodgeModPerLevel { get; set; }
        double RFlatEnergyModPerLevel { get; set; }
        double RFlatEnergyRegenModPerLevel { get; set; }
        double RFlatGoldPer10Mod { get; set; }
        double RFlatHPModPerLevel { get; set; }
        double RFlatHPRegenModPerLevel { get; set; }
        double RFlatMPeModPerLevel { get; set; }
        double RFlatMPRegenModPerLevel { get; set; }
        double RFlatMagicDamageModPerLevel { get; set; }
        double RFlatMagicPenetrationMod { get; set; }
        double RFlatMagicPenetrationModPerLevel { get; set; }
        double RFlatMovementSpeedModPerLevel { get; set; }
        double RFlatPhysicalDamageModPerLevel { get; set; }
        double RFlatSpellBlockModPerLevel { get; set; }
        double RFlatTimeDeadMod { get; set; }
        double RFlatTimeDeadModPerLevel { get; set; }
        double RPercentArmorPenetrationMod { get; set; }
        double RPercentArmorPenetrationModPerLevel { get; set; }
        double RPercentAttackSpeedModPerLevel { get; set; }
        double RPercentCooldownMod { get; set; }
        double RPercentCooldownModPerLevel { get; set; }
        double RPercentMagicPenetrationMod { get; set; }
        double RPercentMagicPenetrationModPerLevel { get; set; }
        double RPercentMovementSpeedModPerLevel { get; set; }
        double RPercentTimeDeadMod { get; set; }
        double RPercentTimeDeadModPerLevel { get; set; }
    }
}