using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Static.Enums;
using PortableLeagueApi.Static.Models.Static.Champion;
using PortableLeagueApi.Static.Models.Static.Item;
using PortableLeagueApi.Static.Models.Static.Mastery;
using PortableLeagueApi.Static.Models.Static.Rune;
using PortableLeagueApi.Static.Models.Static.SummonerSpell;

namespace PortableLeagueApi.Static.Services
{
    public static class StaticServiceExtensions
    {
        public static async Task<ChampionDto> GetChampionStaticInfosAsync(
            this IChampion champion,
            StaticService staticService,
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await staticService.GetChampion(
                    champion.ChampionId,
                    champData,
                    region,
                    languageCode,
                    dataDragonVersion);
        }

        public static async Task<MasteryDto> GetMasteryStaticInfosAsync(
            this IMastery mastery,
            StaticService staticService,
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await staticService.GetMastery(
                mastery.Id,
                masteryData,
                region,
                languageCode,
                dataDragonVersion);
        }

        public static async Task<RuneDto> GetRuneStaticInfosAsync(
            this IRune rune,
            StaticService staticService,
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await staticService.GetRune(
                rune.Id, 
                runeData, 
                region, 
                languageCode, 
                dataDragonVersion);
        }

        public static async Task<IEnumerable<ItemDto>> GetItemsStaticInfosAsync(
            this IItems items,
            StaticService staticService,
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            var result = new List<ItemDto>();

            var itemIds = new List<int>
            {
                items.Item0,
                items.Item1,
                items.Item2,
                items.Item3,
                items.Item4,
                items.Item5,
                items.Item6
            };

            foreach (var itemId in itemIds.Where(x => x > 0))
            {
                var item = await staticService.GetItems(
                    itemId,
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion);

                result.Add(item);
            }

            return result;
        }

        public static async Task<IEnumerable<SummonerSpellDto>> GetSummonerSpellsStaticInfosAsync(
            this ISummonerSpells summonerSpells,
            StaticService staticService,
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            var allSummonerSpells = await staticService.GetSummonerSpells(
                itemData,
                region,
                languageCode,
                dataDragonVersion);

            var summonerSpellsList = new[]
            {
                summonerSpells.SummonerSpell1.ToString(), 
                summonerSpells.SummonerSpell2.ToString()
            };

            return allSummonerSpells.Data
                .Where(x => summonerSpellsList.Contains(x.Value.Key))
                .Select(x => x.Value);
        }
    }
}
