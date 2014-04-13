using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Helpers;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Interfaces.Static.Mastery;
using PortableLeagueApi.Interfaces.Static.Rune;
using PortableLeagueApi.Interfaces.Static.SummonerSpell;
using PortableLeagueApi.Static.Constants;
using PortableLeagueApi.Static.Models;
using PortableLeagueApi.Static.Models.Champion;
using PortableLeagueApi.Static.Models.DTO;
using PortableLeagueApi.Static.Models.DTO.Champion;
using PortableLeagueApi.Static.Models.DTO.Item;
using PortableLeagueApi.Static.Models.DTO.Mastery;
using PortableLeagueApi.Static.Models.DTO.Rune;
using PortableLeagueApi.Static.Models.DTO.SummonerSpell;
using PortableLeagueApi.Static.Models.Item;
using PortableLeagueApi.Static.Models.Mastery;
using PortableLeagueApi.Static.Models.Rune;
using PortableLeagueApi.Static.Models.SummonerSpell;

namespace PortableLeagueApi.Static.Services
{
    public class StaticService : BaseService, IStaticService
    {
        private static readonly Dictionary<Uri, object> Cache = new Dictionary<Uri, object>();

        public StaticService(
            ILeagueApiConfiguration config)
            : base(config, VersionEnum.V1Rev2, "static-data", false)
        { 
            ChampionList.CreateMap(AutoMapperService);
            ItemList.CreateMap(AutoMapperService);
            MasteryList.CreateMap(AutoMapperService);
            Realm.CreateMap(AutoMapperService);
            RuneList.CreateMap(AutoMapperService);
            SummonerSpellList.CreateMap(AutoMapperService);

#if DEBUG
            AutoMapperService.AssertConfigurationIsValid();
#endif
        }

        private static string GetLanguageCode(LanguageEnum? language)
        {
            var value = language.HasValue ? language.Value : LanguageEnum.EnglishUS;

            return LanguageCodeConsts.SupportedLanguages[value];
        }
        
        protected override async Task<T> GetResponseAsync<T>(Uri uri)
        {
            T response;

            object value;
            if (Cache.TryGetValue(uri, out value))
                response = (T)value;
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
            int? id = null,
            params KeyValuePair<string, string>[] additionalParameters) where T : struct
        {
            return BuildStaticUri(
                path,
                dataParameterName,
                data,
                region,
                languageCode,
                dataDragonVersion,
                id.HasValue ? id.Value.ToString() : null,
                additionalParameters);
        }

        private Uri BuildStaticUri<T>(
            string path,
            string dataParameterName,
            T? data,
            RegionEnum? region,
            LanguageEnum? languageCode,
            string dataDragonVersion,
            string id,
            params KeyValuePair<string, string>[] additionalParameters) where T : struct
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

            foreach (var additionalParameter in additionalParameters)
            {
                uriBuilder.AddQueryParameter(string.Format("{0}={1}", additionalParameter.Key, additionalParameter.Value));
            }

            return uriBuilder.Uri;
        }

        public async Task<IChampionList> GetChampionsAsync(
            bool dataById = false,
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<ChampionListDto, IChampionList>(
                BuildStaticUri(
                    "champion", 
                    "champData", 
                    champData, 
                    region, 
                    languageCode, 
                    dataDragonVersion,
                    (string) null,
                    new KeyValuePair<string, string>("dataById", dataById.ToString())));
        }

        public async Task<IChampion> GetChampionAsync(
            int championId,
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<ChampionDto, IChampion>(
                BuildStaticUri(
                    "champion", 
                    "champData", 
                    champData, 
                    region, 
                    languageCode, 
                    dataDragonVersion, 
                    championId));
        }
        public async Task<IItemList> GetItemsAsync(
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<ItemListDto, IItemList>(
                BuildStaticUri(
                    "item",
                    "itemListData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<IItem> GetItemsAsync(
            int itemId,
            ItemDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<ItemDto, IItem>(
                BuildStaticUri(
                    "item",
                    "itemData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    itemId));
        }

        public async Task<IMasteryList> GetMasteriesAsync(
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<MasteryListDto, IMasteryList>(
                BuildStaticUri(
                    "mastery",
                    "masteryListData",
                    masteryData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<IMastery> GetMasteryAsync(
            int masteryId,
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<MasteryDto, IMastery>(
                BuildStaticUri(
                    "mastery",
                    "masteryData",
                    masteryData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    masteryId));
        }

        public async Task<IRealm> GetRealmAsync(
            RegionEnum? region = null)
        {
            return await GetResponseAsync<RealmDto, IRealm>(
                BuildUri(region, "realm"));
        }

        public async Task<IRuneList> GetRunesAsync(
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<RuneListDto, IRuneList>(
                BuildStaticUri(
                    "rune",
                    "runeListData",
                    runeData,
                    region,
                    languageCode,
                    dataDragonVersion));
        }

        public async Task<IRune> GetRuneAsync(
            int runeId,
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<RuneDto, IRune>(
                BuildStaticUri(
                    "rune",
                    "runeData",
                    runeData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    runeId));
        }

        public async Task<ISummonerSpellList> GetSummonerSpellsAsync(
            bool dataById = false,
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<SummonerSpellListDto, ISummonerSpellList>(
                BuildStaticUri(
                    "summoner-spell",
                    "spellData",
                    itemData,
                    region,
                    languageCode,
                    dataDragonVersion,
                    (string) null,
                    new KeyValuePair<string, string>( "dataById", dataById.ToString())));
        }

        public async Task<ISummonerSpell> GetSummonerSpellsAsync(
            int spellId,
            SpellDataEnum? itemData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await GetResponseAsync<SummonerSpellDto, ISummonerSpell>(
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
