using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static
{
    public class Basic
    {
        public string name { get; set; }
        public Rune rune { get; set; }
        public Gold gold { get; set; }
        public string group { get; set; }
        public string description { get; set; }
        public string colloq { get; set; }
        public string plaintext { get; set; }
        public bool consumed { get; set; }
        public int stacks { get; set; }
        public int depth { get; set; }
        public bool consumeOnFull { get; set; }
        public object[] from { get; set; }
        public object[] into { get; set; }
        public int specialRecipe { get; set; }
        public bool inStore { get; set; }
        public bool hideFromAll { get; set; }
        public string requiredChampion { get; set; }
        public Stats stats { get; set; }
        public object[] tags { get; set; }
        public Dictionary<string, bool> maps { get; set; }
    }

    public class Rune
    {
        public bool isrune { get; set; }
        public int tier { get; set; }
        public string type { get; set; }
    }

    public class Gold
    {
        [JsonProperty("base")]
        public int _base { get; set; }
        public int total { get; set; }
        public int sell { get; set; }
        public bool purchasable { get; set; }
    }

    public class Stats
    {
        public float FlatHPPoolMod { get; set; }
        public float rFlatHPModPerLevel { get; set; }
        public float FlatMPPoolMod { get; set; }
        public float rFlatMPModPerLevel { get; set; }
        public float PercentHPPoolMod { get; set; }
        public float PercentMPPoolMod { get; set; }
        public float FlatHPRegenMod { get; set; }
        public float rFlatHPRegenModPerLevel { get; set; }
        public float PercentHPRegenMod { get; set; }
        public float FlatMPRegenMod { get; set; }
        public float rFlatMPRegenModPerLevel { get; set; }
        public float PercentMPRegenMod { get; set; }
        public float FlatArmorMod { get; set; }
        public float rFlatArmorModPerLevel { get; set; }
        public float PercentArmorMod { get; set; }
        public float rFlatArmorPenetrationMod { get; set; }
        public float rFlatArmorPenetrationModPerLevel { get; set; }
        public float rPercentArmorPenetrationMod { get; set; }
        public float rPercentArmorPenetrationModPerLevel { get; set; }
        public float FlatPhysicalDamageMod { get; set; }
        public float rFlatPhysicalDamageModPerLevel { get; set; }
        public float PercentPhysicalDamageMod { get; set; }
        public float FlatMagicDamageMod { get; set; }
        public float rFlatMagicDamageModPerLevel { get; set; }
        public float PercentMagicDamageMod { get; set; }
        public float FlatMovementSpeedMod { get; set; }
        public float rFlatMovementSpeedModPerLevel { get; set; }
        public float PercentMovementSpeedMod { get; set; }
        public float rPercentMovementSpeedModPerLevel { get; set; }
        public float FlatAttackSpeedMod { get; set; }
        public float PercentAttackSpeedMod { get; set; }
        public float rPercentAttackSpeedModPerLevel { get; set; }
        public float rFlatDodgeMod { get; set; }
        public float rFlatDodgeModPerLevel { get; set; }
        public float PercentDodgeMod { get; set; }
        public float FlatCritChanceMod { get; set; }
        public float rFlatCritChanceModPerLevel { get; set; }
        public float PercentCritChanceMod { get; set; }
        public float FlatCritDamageMod { get; set; }
        public float rFlatCritDamageModPerLevel { get; set; }
        public float PercentCritDamageMod { get; set; }
        public float FlatBlockMod { get; set; }
        public float PercentBlockMod { get; set; }
        public float FlatSpellBlockMod { get; set; }
        public float rFlatSpellBlockModPerLevel { get; set; }
        public float PercentSpellBlockMod { get; set; }
        public float FlatEXPBonus { get; set; }
        public float PercentEXPBonus { get; set; }
        public float rPercentCooldownMod { get; set; }
        public float rPercentCooldownModPerLevel { get; set; }
        public float rFlatTimeDeadMod { get; set; }
        public float rFlatTimeDeadModPerLevel { get; set; }
        public float rPercentTimeDeadMod { get; set; }
        public float rPercentTimeDeadModPerLevel { get; set; }
        public float rFlatGoldPer10Mod { get; set; }
        public float rFlatMagicPenetrationMod { get; set; }
        public float rFlatMagicPenetrationModPerLevel { get; set; }
        public float rPercentMagicPenetrationMod { get; set; }
        public float rPercentMagicPenetrationModPerLevel { get; set; }
    }

    public class Image
    {
        public string full { get; set; }
        public string sprite { get; set; }
        public string group { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }
}
