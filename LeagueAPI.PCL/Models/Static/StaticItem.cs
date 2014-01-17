using System.Collections.Generic;
using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Static
{
    public class Basic
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rune")]
        public Rune Rune { get; set; }

        [JsonProperty("gold")]
        public Gold Gold { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("colloq")]
        public string Colloq { get; set; }

        [JsonProperty("plaintext")]
        public string Plaintext { get; set; }

        [JsonProperty("consumed")]
        public bool Consumed { get; set; }

        [JsonProperty("stacks")]
        public int Stacks { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("consumeOnFull")]
        public bool ConsumeOnFull { get; set; }

        [JsonProperty("from")]
        public object[] From { get; set; }

        [JsonProperty("into")]
        public object[] Into { get; set; }

        [JsonProperty("specialRecipe")]
        public int SpecialRecipe { get; set; }

        [JsonProperty("inStore")]
        public bool InStore { get; set; }

        [JsonProperty("hideFromAll")]
        public bool HideFromAll { get; set; }

        [JsonProperty("requiredChampion")]
        public string RequiredChampion { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("maps")]
        public Dictionary<string, bool> Maps { get; set; }
    }

    public class Rune
    {
        [JsonProperty("I-isrune")]
        public bool IsRune { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Gold
    {
        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("sell")]
        public int Sell { get; set; }

        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }
    }

    public class Stats
    {
        [JsonProperty("FlatHPPoolMod")]
        public float FlatHPPoolMod { get; set; }

        [JsonProperty("rFlatHPModPerLevel")]
        public float RFlatHPModPerLevel { get; set; }

        [JsonProperty("FlatMPPoolMod")]
        public float FlatMPPoolMod { get; set; }

        [JsonProperty("rFlatMPModPerLevel")]
        public float RFlatMPModPerLevel { get; set; }

        [JsonProperty("PercentHPPoolMod")]
        public float PercentHPPoolMod { get; set; }

        [JsonProperty("PercentMPPoolMod")]
        public float PercentMPPoolMod { get; set; }

        [JsonProperty("FlatHPRegenMod")]
        public float FlatHPRegenMod { get; set; }

        [JsonProperty("rFlatHPRegenModPerLevel")]
        public float RFlatHPRegenModPerLevel { get; set; }

        [JsonProperty("PercentHPRegenMod")]
        public float PercentHPRegenMod { get; set; }

        [JsonProperty("FlatMPRegenMod")]
        public float FlatMPRegenMod { get; set; }

        [JsonProperty("rFlatMPRegenModPerLevel")]
        public float RFlatMPRegenModPerLevel { get; set; }

        [JsonProperty("PercentMPRegenMod")]
        public float PercentMPRegenMod { get; set; }

        [JsonProperty("FlatArmorMod")]
        public float FlatArmorMod { get; set; }

        [JsonProperty("rFlatArmorModPerLevel")]
        public float RFlatArmorModPerLevel { get; set; }

        [JsonProperty("PercentArmorMod")]
        public float PercentArmorMod { get; set; }

        [JsonProperty("rFlatArmorPenetrationMod")]
        public float RFlatArmorPenetrationMod { get; set; }

        [JsonProperty("rFlatArmorPenetrationModPerLevel")]
        public float RFlatArmorPenetrationModPerLevel { get; set; }

        [JsonProperty("rPercentArmorPenetrationMod")]
        public float RPercentArmorPenetrationMod { get; set; }

        [JsonProperty("rPercentArmorPenetrationModPerLevel")]
        public float RPercentArmorPenetrationModPerLevel { get; set; }

        [JsonProperty("FlatPhysicalDamageMod")]
        public float FlatPhysicalDamageMod { get; set; }

        [JsonProperty("rFlatPhysicalDamageModPerLevel")]
        public float RFlatPhysicalDamageModPerLevel { get; set; }

        [JsonProperty("PercentPhysicalDamageMod")]
        public float PercentPhysicalDamageMod { get; set; }

        [JsonProperty("FlatMagicDamageMod")]
        public float FlatMagicDamageMod { get; set; }

        [JsonProperty("rFlatMagicDamageModPerLevel")]
        public float RFlatMagicDamageModPerLevel { get; set; }

        [JsonProperty("PercentMagicDamageMod")]
        public float PercentMagicDamageMod { get; set; }

        [JsonProperty("FlatMovementSpeedMod")]
        public float FlatMovementSpeedMod { get; set; }

        [JsonProperty("rFlatMovementSpeedModPerLevel")]
        public float RFlatMovementSpeedModPerLevel { get; set; }

        [JsonProperty("PercentMovementSpeedMod")]
        public float PercentMovementSpeedMod { get; set; }

        [JsonProperty("rPercentMovementSpeedModPerLevel")]
        public float RPercentMovementSpeedModPerLevel { get; set; }

        [JsonProperty("FlatAttackSpeedMod")]
        public float FlatAttackSpeedMod { get; set; }

        [JsonProperty("PercentAttackSpeedMod")]
        public float PercentAttackSpeedMod { get; set; }

        [JsonProperty("rPercentAttackSpeedModPerLevel")]
        public float RPercentAttackSpeedModPerLevel { get; set; }

        [JsonProperty("rFlatDodgeMod")]
        public float RFlatDodgeMod { get; set; }

        [JsonProperty("rFlatDodgeModPerLevel")]
        public float RFlatDodgeModPerLevel { get; set; }

        [JsonProperty("PercentDodgeMod")]
        public float PercentDodgeMod { get; set; }

        [JsonProperty("FlatCritChanceMod")]
        public float FlatCritChanceMod { get; set; }

        [JsonProperty("rFlatCritChanceModPerLevel")]
        public float RFlatCritChanceModPerLevel { get; set; }

        [JsonProperty("PercentCritChanceMod")]
        public float PercentCritChanceMod { get; set; }

        [JsonProperty("FlatCritDamageMod")]
        public float FlatCritDamageMod { get; set; }

        [JsonProperty("rFlatCritDamageModPerLevel")]
        public float RFlatCritDamageModPerLevel { get; set; }

        [JsonProperty("PercentCritDamageMod")]
        public float PercentCritDamageMod { get; set; }

        [JsonProperty("FlatBlockMod")]
        public float FlatBlockMod { get; set; }

        [JsonProperty("PercentBlockMod")]
        public float PercentBlockMod { get; set; }

        [JsonProperty("FlatSpellBlockMod")]
        public float FlatSpellBlockMod { get; set; }

        [JsonProperty("rFlatSpellBlockModPerLevel")]
        public float RFlatSpellBlockModPerLevel { get; set; }

        [JsonProperty("PercentSpellBlockMod")]
        public float PercentSpellBlockMod { get; set; }

        [JsonProperty("FlatEXPBonus")]
        public float FlatEXPBonus { get; set; }

        [JsonProperty("PercentEXPBonus")]
        public float PercentEXPBonus { get; set; }

        [JsonProperty("rPercentCooldownMod")]
        public float RPercentCooldownMod { get; set; }

        [JsonProperty("rPercentCooldownModPerLevel")]
        public float RPercentCooldownModPerLevel { get; set; }

        [JsonProperty("rFlatTimeDeadMod")]
        public float RFlatTimeDeadMod { get; set; }

        [JsonProperty("rFlatTimeDeadModPerLevel")]
        public float RFlatTimeDeadModPerLevel { get; set; }

        [JsonProperty("rPercentTimeDeadMod")]
        public float RPercentTimeDeadMod { get; set; }

        [JsonProperty("rPercentTimeDeadModPerLevel")]
        public float RPercentTimeDeadModPerLevel { get; set; }

        [JsonProperty("rFlatGoldPer10Mod")]
        public float RFlatGoldPer10Mod { get; set; }

        [JsonProperty("rFlatMagicPenetrationMod")]
        public float RFlatMagicPenetrationMod { get; set; }

        [JsonProperty("rFlatMagicPenetrationModPerLevel")]
        public float RFlatMagicPenetrationModPerLevel { get; set; }

        [JsonProperty("rPercentMagicPenetrationMod")]
        public float RPercentMagicPenetrationMod { get; set; }

        [JsonProperty("rPercentMagicPenetrationModPerLevel")]
        public float RPercentMagicPenetrationModPerLevel { get; set; }
    }

    public class Image
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("sprite")]
        public string Sprite { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("w")]
        public int Width { get; set; }

        [JsonProperty("h")]
        public int Height { get; set; }
    }
}
