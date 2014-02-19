using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Helpers;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Static.Constants;
using PortableLeagueApi.Static.Enums;
using PortableLeagueApi.Static.Models.Static;
using PortableLeagueApi.Static.Models.Static.Champion;
using PortableLeagueApi.Static.Models.Static.Item;
using PortableLeagueApi.Static.Models.Static.Mastery;
using PortableLeagueApi.Static.Models.Static.Rune;
using PortableLeagueApi.Static.Models.Static.SummonerSpell;

namespace PortableLeagueApi.Static.Services
{
    public class StaticService : BaseService
    {
        private static readonly Dictionary<Uri, object> Cache = new Dictionary<Uri, object>();

        public StaticService(
            string key,
            IHttpRequestService httpRequestService, 
            RegionEnum? defaultRegion, 
            bool waitToAvoidRateLimit)
            : base(key, httpRequestService, VersionEnum.V1, "static-data", defaultRegion, waitToAvoidRateLimit, false)
        { }

        private static string GetLanguageCode(LanguageEnum? language)
        {
            var value = language.HasValue ? language.Value : LanguageEnum.EnglishUS;

            return LanguageCodeConsts.SupportedLanguages[value];
        }
        
        protected override async Task<T> GetResponseAsync<T>(Uri uri)
        {
            T response;

            if (Cache.ContainsKey(uri))
                response = (T)Cache[uri];
            else
                response = await base.GetResponseAsync<T>(uri);

            Cache[uri] = response;

            return response;
        }

        protected override Uri BuildUri(RegionEnum? region, string relativeUrl)
        {
            relativeUrl = string.Format("{0}/{1}/{2}/{3}",
                   Prefix,
                   GetRegionAsString(region),
                   VersionText,
                   relativeUrl);
            
            return BuildUri(new Uri(relativeUrl, UriKind.Relative));
        }

        private Uri BuildStaticUri<T>(
            string path,
            string dataParameterName,
            T? data,
            RegionEnum? region,
            LanguageEnum? languageCode,
            string dataDragonVersion,
            int? id = null) where T : struct
        {
            return BuildStaticUri(
                path,
                dataParameterName,
                data,
                region,
                languageCode,
                dataDragonVersion,
                id.HasValue ? id.Value.ToString() : null);
        }

        private Uri BuildStaticUri<T>(
            string path,
            string dataParameterName,
            T? data,
            RegionEnum? region,
            LanguageEnum? languageCode,
            string dataDragonVersion,
            string id) where T : struct
        {
            var uri = BuildUri(region, path);

            var uriBuilder = new UriBuilder(uri);

            if (languageCode.HasValue)
                uriBuilder.AddQueryParameter(string.Format("locale={0}", GetLanguageCode(languageCode)));

            if (!string.IsNullOrWhiteSpace(dataDragonVersion))
                uriBuilder.AddQueryParameter(string.Format("version={0}", dataDragonVersion));

            if (data.HasValue)
                uriBuilder.AddQueryParameter(string.Format("{0}={1}", dataParameterName, data.Value.ToString().ToLower()));

            if (id != null)
                uriBuilder.Path += string.Format("/{0}", id);

            return uriBuilder.Uri;
        }

        public async Task<ChampionListDto> GetChampionsAsync(
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<ChampionListDto>(
                BuildStaticUri(
                    "champion", 
                    "champData", 
                    champData, 
                    region, 
                    languageCode, 
                    dataDragonVersion));
        }

        public async Task<ChampionDto> GetChampionAsync(
            int championId,
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<ChampionDto>(
                BuildStaticUri(
                    "champion", 
                    "champData", 
                    champData, 
                    region, 
                    languageCode, 
                    dataDragonVersion, 
                    championId));
        }
        public async Task<ItemListDto> GetItemsAsync(
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<ItemListDto>(
                BuildStaticUri(
                    "item",
                    "itemListData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<ItemDto> GetItemsAsync(
            int itemId,
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<ItemDto>(
                BuildStaticUri(
                    "item",
                    "itemListData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    itemId));
        }

        public async Task<MasteryListDto> GetMasteriesAsync(
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<MasteryListDto>(
                BuildStaticUri(
                    "mastery",
                    "masteryListData",
                    masteryData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<MasteryDto> GetMasteryAsync(
            int masteryId,
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<MasteryDto>(
                BuildStaticUri(
                    "mastery",
                    "masteryListData",
                    masteryData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    masteryId));
        }

        public async Task<RealmDto> GetRealmAsync(
            RegionEnum? region = null)
        {
            return await GetResponseAsync<RealmDto>(
                BuildUri(region, "realm"));
        }

        public async Task<RuneListDto> GetRunesAsync(
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<RuneListDto>(
                BuildStaticUri(
                    "rune",
                    "runeListData",
                    runeData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<RuneDto> GetRuneAsync(
            int runeId,
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<RuneDto>(
                BuildStaticUri(
                    "rune",
                    "runeListData",
                    runeData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    runeId));
        }

        public async Task<SummonerSpellListDto> GetSummonerSpellsAsync(
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<SummonerSpellListDto>(
                BuildStaticUri(
                    "summoner-spell",
                    "spellData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<SummonerSpellDto> GetSummonerSpellsAsync(
            string spellId,
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<SummonerSpellDto>(
                BuildStaticUri(
                    "summoner-spell",
                    "spellData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    spellId));
        }
    }
}
