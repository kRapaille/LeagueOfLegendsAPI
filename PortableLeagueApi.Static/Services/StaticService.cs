using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Helpers;
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
        private static StaticService _instance;
        private static readonly Dictionary<Uri, object> Cache = new Dictionary<Uri, object>();

        private StaticService() : base(VersionEnum.V1, "static-data", false) { }

        public static StaticService Instance
        {
            get { return _instance ?? (_instance = new StaticService()); }
        }

        private static string GetLanguageCode(LanguageEnum? language)
        {
            var value = language.HasValue ? language.Value : LanguageEnum.EnglishUS;

            return LanguageCodeConsts.SupportedLanguages[value];
        }
        
        protected override async Task<T> GetResponse<T>(Uri uri)
        {
            T response;

            if (Cache.ContainsKey(uri))
                response = (T)Cache[uri];
            else
                response = await base.GetResponse<T>(uri);

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

        public async Task<ChampionListDto> GetChampions(
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<ChampionListDto>(
                BuildStaticUri(
                    "champion", 
                    "champData", 
                    champData, 
                    region, 
                    languageCode, 
                    dataDragonVersion));
        }

        public async Task<ChampionDto> GetChampion(
            int championId,
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<ChampionDto>(
                BuildStaticUri(
                    "champion", 
                    "champData", 
                    champData, 
                    region, 
                    languageCode, 
                    dataDragonVersion, 
                    championId));
        }
        public async Task<ItemListDto> GetItems(
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<ItemListDto>(
                BuildStaticUri(
                    "item",
                    "itemListData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<ItemDto> GetItems(
            int itemId,
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<ItemDto>(
                BuildStaticUri(
                    "item",
                    "itemListData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    itemId));
        }

        public async Task<MasteryListDto> GetMasteries(
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<MasteryListDto>(
                BuildStaticUri(
                    "mastery",
                    "masteryListData",
                    masteryData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<MasteryDto> GetMastery(
            int masteryId,
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<MasteryDto>(
                BuildStaticUri(
                    "mastery",
                    "masteryListData",
                    masteryData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    masteryId));
        }

        public async Task<RealmDto> GetRealm(
            RegionEnum? region = null)
        {
            return await GetResponse<RealmDto>(
                BuildUri(region, "realm"));
        }

        public async Task<RuneListDto> GetRunes(
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<RuneListDto>(
                BuildStaticUri(
                    "rune",
                    "runeListData",
                    runeData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<RuneDto> GetRune(
            int runeId,
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<RuneDto>(
                BuildStaticUri(
                    "rune",
                    "runeListData",
                    runeData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    runeId));
        }

        public async Task<SummonerSpellListDto> GetSummonerSpells(
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<SummonerSpellListDto>(
                BuildStaticUri(
                    "summoner-spell",
                    "spellData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<SummonerSpellDto> GetSummonerSpells(
            string spellId,
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponse<SummonerSpellDto>(
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
