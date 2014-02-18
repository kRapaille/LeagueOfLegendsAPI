using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Static.Enums;
using PortableLeagueApi.Static.Models.Static.Champion;
using PortableLeagueApi.Static.Models.Static.Mastery;
using PortableLeagueApi.Static.Models.Static.Rune;

namespace PortableLeagueApi.Static.Services
{
    public static class StaticServiceExtensions
    {
        public static async Task<ChampionDto> GetChampionStaticInfos(
            IChampion champion,
            ChampDataEnum? champData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await StaticService.Instance.GetChampion(
                    champion.ChampionId,
                    champData,
                    region,
                    languageCode,
                    dataDragonVersion);
        }

        public static async Task<MasteryDto> GetMasteryStaticInfos(
            IMastery mastery,
            MasteryDataEnum? masteryData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await StaticService.Instance.GetMastery(
                mastery.Id,
                masteryData,
                region,
                languageCode,
                dataDragonVersion);
        }

        public static async Task<RuneDto> GetRuneStaticInfos(
            IRune rune,
            RuneDataEnum? runeData = null,
            RegionEnum? region = null,
            LanguageEnum? languageCode = null,
            string dataDragonVersion = null)
        {
            return await StaticService.Instance.GetRune(
                rune.Id, 
                runeData, 
                region, 
                languageCode, 
                dataDragonVersion);
        }
    }
}
