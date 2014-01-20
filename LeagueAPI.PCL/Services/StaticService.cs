using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueAPI.Models.Constants;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Static;

namespace PortableLeagueAPI.Services
{
    public class StaticService : BaseService
    {
        private static readonly Dictionary<RegionEnum, StaticAPIVersions> StaticAPIVersions = new Dictionary<RegionEnum, StaticAPIVersions>();
        private static StaticService _instance;

        private StaticService()
        {
            IsLimitedByRateLimit = false;
        }

        internal static StaticService Instance
        {
            get { return _instance ?? (_instance = new StaticService()); }
        }

        private static string GetLanguageCode(LanguageEnum? language)
        {
            var value = language.HasValue ? language.Value : LanguageEnum.EnglishUS;

            return LanguageCodeConsts.SupportedLanguages[value];
        }
        
        private async Task<StaticAPIVersions> GetVersioningByRegion(
            RegionEnum? region = null)
        {
            var regionValue = GetRegion(region);

            if (!StaticAPIVersions.ContainsKey(regionValue))
            {
                var url = string.Format("http://ddragon.leagueoflegends.com/realms/{0}.json",
                    GetRegionAsString(region));

                var result = await GetResponse<StaticVersioningRoot>(new Uri(url), false);

                return result.StaticAPIVersions;
            }

            return StaticAPIVersions[regionValue];
        }

        public async Task<Dictionary<string, Item>> GetItems(
            RegionEnum? region = null,
            LanguageEnum? languageCode = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/{1}/item.json",
                    lastVersions.Item,
                    GetLanguageCode(languageCode));

            var result = await GetResponse<ItemRootObject>(new Uri(url), false);

            return result.Data;
        }

        public async Task<Dictionary<string, RuneItem>> GetRunes(
            RegionEnum? region = null,
            LanguageEnum? languageCode = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/{1}/rune.json",
                    lastVersions.Rune,
                    GetLanguageCode(languageCode));

            var result = await GetResponse<RuneRootObject>(new Uri(url), false);

            return result.Data;
        }

        public async Task<Dictionary<string, Mastery>> GetMasteries(
            RegionEnum? region = null,
            LanguageEnum? languageCode = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/{1}/mastery.json",
                    lastVersions.Mastery,
                    GetLanguageCode(languageCode));

            var result = await GetResponse<MasteryRootobject>(new Uri(url), false);

            return result.Data;
        }

        public async Task<Dictionary<string, Summoner>> GetSummoners(
            RegionEnum? region = null,
            LanguageEnum? languageCode = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/{1}/summoner.json",
                    lastVersions.Mastery,
                    GetLanguageCode(languageCode));

            var result = await GetResponse<SummonerRootobject>(new Uri(url), false);

            return result.Data;
        }

        public async Task<Dictionary<string, StaticChampion>> GetChampions(
            RegionEnum? region = null,
            LanguageEnum? languageCode = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/{1}/champion.json",
                    lastVersions.Champion,
                    GetLanguageCode(languageCode));

            var result = await GetResponse<StaticChampionRoot>(new Uri(url), false);

            return result.Data;
        }

        public async Task<Dictionary<int, ProfileIcon>> GetProfileIcons(
            RegionEnum? region = null,
            LanguageEnum? languageCode = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/{1}/profileicon.json",
                    lastVersions.Profileicon,
                    GetLanguageCode(languageCode));

            var result = await GetResponse<ProfileIconRoot>(new Uri(url), false);

            return result.Data;
        }

        public async Task<Dictionary<string, string>> GetLanguages(
            RegionEnum? region = null,
            LanguageEnum? languageCode = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/{1}/language.json",
                    lastVersions.Language,
                    GetLanguageCode(languageCode));

            var result = await GetResponse<LanguageRoot>(new Uri(url), false);

            return result.Data;
        }
    }
}
