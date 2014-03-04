using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Interfaces.Static.Mastery;
using PortableLeagueApi.Interfaces.Static.SummonerSpell;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Static.Services;
using IRune = PortableLeagueApi.Interfaces.Static.Rune.IRune;

namespace PortableLeagueApi.Static.Extensions
{
    public static class StaticServiceExtensions
    {
        public static async Task<IChampion> GetChampionStaticInfosAsync(
            this IHasChampionId hasChampionId,
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            if (hasChampionId == null) throw new ArgumentNullException("hasChampionId");

            var staticService = new StaticService(hasChampionId.ApiConfiguration);

            return await staticService.GetChampionAsync(
                    hasChampionId.ChampionId,
                    champData,
                    region,
                    languageCode,
                    dataDragonVersion);
        }

        public static async Task<IMastery> GetMasteryStaticInfosAsync(
            this IHasMasteryId hasMasteryId,
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            if (hasMasteryId == null) throw new ArgumentNullException("hasMasteryId");

            var staticService = new StaticService(hasMasteryId.ApiConfiguration);

            return await staticService.GetMasteryAsync(
                hasMasteryId.Id,
                masteryData,
                region,
                languageCode,
                dataDragonVersion);
        }

        public static async Task<IRune> GetRuneStaticInfosAsync(
            this IHasRuneId hasRuneId,
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            if (hasRuneId == null) throw new ArgumentNullException("hasRuneId");

            var staticService = new StaticService(hasRuneId.ApiConfiguration);

            return await staticService.GetRuneAsync(
                hasRuneId.Id,
                runeData,
                region,
                languageCode,
                dataDragonVersion);
        }

        public static async Task<IEnumerable<IItem>> GetItemsStaticInfosAsync(
            this IHasItemIds hasItemIds,
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            if (hasItemIds == null) throw new ArgumentNullException("hasItemIds");

            var result = new List<IItem>();

            var staticService = new StaticService(hasItemIds.ApiConfiguration);

            foreach (var itemId in hasItemIds.ItemIds.Where(x => x > 0))
            {
                var item = await staticService.GetItemsAsync(
                    itemId,
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion);

                result.Add(item);
            }

            return result;
        }

        public static async Task<IEnumerable<ISummonerSpell>> GetSummonerSpellsStaticInfosAsync(
            this IHasSummonerSpells hasSummonerSpells,
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            if (hasSummonerSpells == null) throw new ArgumentNullException("hasSummonerSpells");

            var staticService = new StaticService(hasSummonerSpells.ApiConfiguration);

            var allSummonerSpells = await staticService.GetSummonerSpellsAsync(
                itemData,
                region,
                languageCode,
                dataDragonVersion);
            
            return allSummonerSpells.Data
                .Where(x => hasSummonerSpells.SummonerSpells.Select(z => z.ToString()).Contains(x.Value.Key))
                .Select(x => x.Value);
        }

        private static async Task<string> GetImageUrlAsync(
            string group,
            string image,
            IStaticService staticService,
            RegionEnum? region = null,
            string dataDragonVersion = null)
        {
            if (group == null) throw new ArgumentNullException("group");
            if (image == null) throw new ArgumentNullException("image");
            if (staticService == null) throw new ArgumentNullException("staticService");

            if (string.IsNullOrWhiteSpace(dataDragonVersion))
            {
                var realm = await staticService.GetRealmAsync(region);
                dataDragonVersion = realm.CurrentVersion;
            }

            return string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/img/{1}/{2}",
                dataDragonVersion,
                group,
                image);
        }

        public static async Task<string> GetUrlAsync(
            this IImage imageDto,
            RegionEnum? region = null,
            string dataDragonVersion = null)
        {
            if (imageDto == null) throw new ArgumentNullException("imageDto");

            var staticService = new StaticService(imageDto.ApiConfiguration);

            return await GetImageUrlAsync(
                imageDto.Group,
                imageDto.Full,
                staticService,
                region,
                dataDragonVersion);
        }

        public static async Task<string> GetProfileIconUrlAsync(
            this ISummoner summoner,
            RegionEnum? region = null,
            string dataDragonVersion = null)
        {
            if (summoner == null) throw new ArgumentNullException("summoner");

            var staticService = new StaticService(summoner.ApiConfiguration);

            return await GetImageUrlAsync(
                "profileicon",
                string.Format("{0}.png", summoner.ProfileIconId),
                staticService,
                region,
                dataDragonVersion);
        }

        public static async Task<IEnumerable<string>> GetItemsImageUrlsAsync(
            this IHasItemIds hasItemIds,
            RegionEnum? region = null,
            string dataDragonVersion = null)
        {
            if (hasItemIds == null) throw new ArgumentNullException("hasItemIds");

            var staticService = new StaticService(hasItemIds.ApiConfiguration);

            if (string.IsNullOrWhiteSpace(dataDragonVersion))
            {
                var realm = await staticService.GetRealmAsync(region);
                dataDragonVersion = realm.CurrentVersion;
            }

            return hasItemIds.ItemIds
                .Where(x => x > 0)
                .Select(x =>
                    string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/img/item/{1}.png",
                    dataDragonVersion,
                    x));
        }

        public static async Task<string> GetChampionImageUrlAsync(
            this IChampion champion,
            RegionEnum? region = null,
            string dataDragonVersion = null)
        {
            if (champion == null) throw new ArgumentNullException("champion");

            var staticService = new StaticService(champion.ApiConfiguration);

            return await GetImageUrlAsync(
                "champion",
                string.Format("{0}.png", champion.Name),
                staticService,
                region,
                dataDragonVersion);
        }

        public static async Task<string> GetSpriteUrlAsync(
            this IImage image,
            RegionEnum? region = null,
            string dataDragonVersion = null)
        {
            if (image == null) throw new ArgumentNullException("image");

            var staticService = new StaticService(image.ApiConfiguration);

            return await GetImageUrlAsync(
                "sprite",
                image.Sprite,
                staticService,
                region,
                dataDragonVersion);
        }

        public static IEnumerable<string> GetSpasheImmagesUrls(
            this IChampion champion,
            RegionEnum? region = null)
        {
            if (champion == null) throw new ArgumentNullException("champion");

            return champion.Skins.Select(
                    skin => string.Format("http://ddragon.leagueoflegends.com/cdn/img/champion/splash/{0}_{1}.jpg",
                        champion.Name,
                        skin.Num));
        }

        public static IEnumerable<string> GetLoadingImagesUrls(
            this IChampion champion,
            RegionEnum? region = null)
        {
            if (champion == null) throw new ArgumentNullException("champion");

            return champion.Skins.Select(
                    skin => string.Format("http://ddragon.leagueoflegends.com/cdn/img/champion/loading/{0}_{1}.jpg",
                        champion.Name,
                        skin.Num));
        }
    }
}
