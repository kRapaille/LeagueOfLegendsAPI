using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Interfaces.Static.Mastery;
using PortableLeagueApi.Interfaces.Static.Rune;
using PortableLeagueApi.Interfaces.Static.SummonerSpell;

namespace PortableLeagueApi.Interfaces.Static
{
    public interface IStaticService
    {
        Task<IChampionList> GetChampionsAsync(
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);

        Task<IChampion> GetChampionAsync(
            int championId,
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);

        Task<IItemList> GetItemsAsync(
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);

        Task<IItem> GetItemsAsync(
            int itemId,
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);

        Task<IMasteryList> GetMasteriesAsync(
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);

        Task<IMastery> GetMasteryAsync(
            int masteryId,
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);

        Task<IRealm> GetRealmAsync(
            RegionEnum? region = null);

        Task<IRuneList> GetRunesAsync(
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);

        Task<IRune> GetRuneAsync(
            int runeId,
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);

        Task<ISummonerSpellList> GetSummonerSpellsAsync(
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);

        Task<ISummonerSpell> GetSummonerSpellsAsync(
            string spellId,
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null);
    }
}