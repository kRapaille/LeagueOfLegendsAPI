using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Static.Enums;

namespace PortableLeagueApi.Static.Services
{
    public static class StaticServiceExtensions
    {
        // -> ChampionId = ChampionDto, ChampionStatsDto, PlayerDto, GameDto

        //public static async Task<ChampionDto> GetChampionStaticInfosAsync(
        //    this IChampionId championId,
        //    StaticService staticService,
        //    ChampDataEnum? champData = null,
        //    RegionEnum? region = null,
        //    LanguageEnum? languageCode = null,
        //    string dataDragonVersion = null)
        //{
        //    return await staticService.GetChampionAsync(
        //            championId.ChampionId,
        //            champData,
        //            region,
        //            languageCode,
        //            dataDragonVersion);
        //}

        // IMastery = TalentDto

        //public static async Task<MasteryDto> GetMasteryStaticInfosAsync(
        //    this IMastery mastery,
        //    StaticService staticService,
        //    MasteryDataEnum? masteryData = null,
        //    RegionEnum? region = null,
        //    LanguageEnum? languageCode = null,
        //    string dataDragonVersion = null)
        //{
        //    return await staticService.GetMasteryAsync(
        //        mastery.Id,
        //        masteryData,
        //        region,
        //        languageCode,
        //        dataDragonVersion);
        //}

        // IRune = RuneDto

        //public static async Task<RuneDto> GetRuneStaticInfosAsync(
        //    this IRune rune,
        //    StaticService staticService,
        //    RuneDataEnum? runeData = null,
        //    RegionEnum? region = null,
        //    LanguageEnum? languageCode = null,
        //    string dataDragonVersion = null)
        //{
        //    return await staticService.GetRuneAsync(
        //        rune.Id, 
        //        runeData, 
        //        region, 
        //        languageCode, 
        //        dataDragonVersion);
        //}

        //private static IEnumerable<int> GetItemIds(IItems items)
        //{
        //    return new List<int>
        //    {
        //        items.Item0,
        //        items.Item1,
        //        items.Item2,
        //        items.Item3,
        //        items.Item4,
        //        items.Item5,
        //        items.Item6
        //    };
        //}

        // ITems = RawStatsDto

        //public static async Task<IEnumerable<ItemDto>> GetItemsStaticInfosAsync(
        //    this IItems items,
        //    StaticService staticService,
        //    ItemDataEnum? itemData = null,
        //    RegionEnum? region = null,
        //    LanguageEnum? languageCode = null,
        //    string dataDragonVersion = null)
        //{
        //    var result = new List<ItemDto>();

        //    foreach (var itemId in GetItemIds(items).Where(x => x > 0))
        //    {
        //        var item = await staticService.GetItemsAsync(
        //            itemId,
        //            itemData,
        //            region,
        //            languageCode,
        //            dataDragonVersion);

        //        result.Add(item);
        //    }

        //    return result;
        //}

        // ISummonerSpells = RawStatsDto, GameDto

        //public static async Task<IEnumerable<SummonerSpellDto>> GetSummonerSpellsStaticInfosAsync(
        //    this ISummonerSpells summonerSpells,
        //    StaticService staticService,
        //    SpellDataEnum? itemData = null,
        //    RegionEnum? region = null,
        //    LanguageEnum? languageCode = null,
        //    string dataDragonVersion = null)
        //{
        //    var allSummonerSpells = await staticService.GetSummonerSpellsAsync(
        //        itemData,
        //        region,
        //        languageCode,
        //        dataDragonVersion);

        //    var summonerSpellsList = new[]
        //    {
        //        summonerSpells.SummonerSpell1.ToString(), 
        //        summonerSpells.SummonerSpell2.ToString()
        //    };

        //    return allSummonerSpells.Data
        //        .Where(x => summonerSpellsList.Contains(x.Value.Key))
        //        .Select(x => x.Value);
        //}

        //private static async Task<string> GetImageUrlAsync(
        //    string group,
        //    string image,
        //    StaticService staticService,
        //    RegionEnum? region = null,
        //    string dataDragonVersion = null)
        //{
        //    if (string.IsNullOrWhiteSpace(dataDragonVersion))
        //    {
        //        var realm = await staticService.GetRealmAsync(region);
        //        dataDragonVersion = realm.V;
        //    }

        //    return string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/img/{1}/{2}",
        //        dataDragonVersion,
        //        group,
        //        image);
        //}

        //public static async Task<string> GetUrlAsync(
        //    this ImageDto imageDto,
        //    StaticService staticService,
        //    RegionEnum? region = null,
        //    string dataDragonVersion = null)
        //{
        //    return await GetImageUrlAsync(
        //        imageDto.Group,
        //        imageDto.Full,
        //        staticService,
        //        region,
        //        dataDragonVersion);
        //}

        // IProfileIcon = SummonerDto

        //public static async Task<string> GetProfileIconUrlAsync(
        //    this IProfileIcon summoner,
        //    StaticService staticService,
        //    RegionEnum? region = null,
        //    string dataDragonVersion = null)
        //{
        //    return await GetImageUrlAsync(
        //        "profileicon",
        //        string.Format("{0}.png", summoner.ProfileIconId),
        //        staticService,
        //        region,
        //        dataDragonVersion);
        //}

        //public static async Task<IEnumerable<string>> GetItemsImageUrlsAsync(
        //    this IItems items,
        //    StaticService staticService,
        //    RegionEnum? region = null,
        //    string dataDragonVersion = null)
        //{
        //    if (string.IsNullOrWhiteSpace(dataDragonVersion))
        //    {
        //        var realm = await staticService.GetRealmAsync(region);
        //        dataDragonVersion = realm.V;
        //    }

        //    return GetItemIds(items)
        //        .Where(x => x > 0)
        //        .Select(x => 
        //            string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/img/item/{1}.png",
        //            dataDragonVersion,
        //            x));
        //}

        // IChampionImage = ChampionDto

        //public static async Task<string> GetChampionImageUrlAsync(
        //    this IChampionImage championImage,
        //    StaticService staticService,
        //    RegionEnum? region = null,
        //    string dataDragonVersion = null)
        //{
        //    return await GetImageUrlAsync(
        //        "champion",
        //        string.Format("{0}.png", championImage.Name),
        //        staticService,
        //        region,
        //        dataDragonVersion);
        //}

        //public static async Task<string> GetSpriteUrlAsync(
        //    this ImageDto imageDto,
        //    StaticService staticService,
        //    RegionEnum? region = null,
        //    string dataDragonVersion = null)
        //{
        //    if (imageDto == null)
        //        return string.Empty;

        //    return await GetImageUrlAsync(
        //        "sprite",
        //        imageDto.Sprite,
        //        staticService,
        //        region,
        //        dataDragonVersion);
        //}

        //public static IEnumerable<string> GetSpasheImmagesUrls(
        //    this ChampionDto championDto,
        //    StaticService staticService,
        //    RegionEnum? region = null)
        //{
        //    return championDto.Skins.Select(
        //            skin => string.Format("http://ddragon.leagueoflegends.com/cdn/img/champion/splash/{0}_{1}.jpg",
        //                championDto.Name,
        //                skin.Num));
        //}

        //public static IEnumerable<string> GetLoadingImagesUrls(
        //    this ChampionDto championDto,
        //    StaticService staticService,
        //    RegionEnum? region = null)
        //{
        //    return championDto.Skins.Select(
        //            skin => string.Format("http://ddragon.leagueoflegends.com/cdn/img/champion/loading/{0}_{1}.jpg",
        //                championDto.Name,
        //                skin.Num));
        //}
    }
}
