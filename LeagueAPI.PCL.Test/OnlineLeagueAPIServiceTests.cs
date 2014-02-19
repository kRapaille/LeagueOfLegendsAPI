using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Static.Enums;
using PortableLeagueApi.Static.Services;

namespace PortableLeagueAPI.Test
{
    [TestFixture]
    public class OnlineLeagueAPIServiceTests
    {
        private readonly LeagueAPI _leagueAPI;

        public OnlineLeagueAPIServiceTests()
        {
            // TODO : Don't forget to pass your api key
            _leagueAPI = new LeagueAPI(string.Empty, RegionEnum.Euw, true);
        }

        [Test]
        [Category("Static")]
        public async void CacheTest()
        {
            var sw = new Stopwatch();
            sw.Start();

            var result = await _leagueAPI.Static.GetChampionsAsync();

            sw.Stop();
            sw.Restart();

            var result2 = await _leagueAPI.Static.GetChampionsAsync();

            sw.Stop();
            var secondTime = sw.ElapsedMilliseconds;

            Assert.NotNull(result);
            Assert.NotNull(result2);
            Assert.Less(secondTime, 10);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticChampionsTest()
        {
            var result = await _leagueAPI.Static.GetChampionsAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticChampionsWithParametersTest()
        {
            var result = await _leagueAPI.Static.GetChampionAsync(13, ChampDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticItemsTest()
        {
            var result = await _leagueAPI.Static.GetItemsAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticItemsWithParametersTest()
        {
            var result = await _leagueAPI.Static.GetItemsAsync(1001, ItemDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticMasteriesTest()
        {
            var result = await _leagueAPI.Static.GetMasteriesAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticMasteriesWithParametersTest()
        {
            var result = await _leagueAPI.Static.GetMasteryAsync(4353, MasteryDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetRealm()
        {
            var result = await _leagueAPI.Static.GetRealmAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticRunesTest()
        {
            var result = await _leagueAPI.Static.GetRunesAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticRunesWithParametersTest()
        {
            var result = await _leagueAPI.Static.GetRuneAsync(5235, RuneDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticSummonerSpellsTest()
        {
            var result = await _leagueAPI.Static.GetSummonerSpellsAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticSummonerSpellsWithParametersTest()
        {
            var result = await _leagueAPI.Static.GetSummonerSpellsAsync("SummonerTeleport", SpellDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void ChampionExtensionsTest()
        {
            var champions = await _leagueAPI.Champion.GetChampionsAsync(true);
            Assert.NotNull(champions);

            var result = await champions.First().GetChampionStaticInfosAsync(_leagueAPI.Static);

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void MasteryExtensionsTest()
        {
            var masteriesPage = await _leagueAPI.Summoner.GetMasteryPagesBySummonerIdAsync(19231046);
            Assert.NotNull(masteriesPage);

            var result = await masteriesPage.First().Talents.First().GetMasteryStaticInfosAsync(_leagueAPI.Static);

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void RuneExtensionsTest()
        {
            var runesPages = await _leagueAPI.Summoner.GetRunePagesBySummonerIdAsync(19231046);
            Assert.NotNull(runesPages);

            var result = await runesPages.First().Slots.First().Rune.GetRuneStaticInfosAsync(_leagueAPI.Static);

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void ItemsExtensionsTest()
        {
            var recentGames = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(19231046);
            Assert.NotNull(recentGames);

            var result = await recentGames.First().Stats.GetItemsStaticInfosAsync(_leagueAPI.Static);

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void SummonerSpellExtensionsTest()
        {
            var recentGames = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(19231046);
            Assert.NotNull(recentGames);

            var result = await recentGames.First().GetSummonerSpellsStaticInfosAsync(_leagueAPI.Static);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Others")]
        public async void TenSecRateLimitTest()
        {
            var start = DateTime.Now;

            for (var i = 0; i < 15; i++)
            {
                Debug.WriteLine(i);
                await _leagueAPI.Champion.GetChampionsAsync(true);
            }

            var diff = DateTime.Now.Subtract(start).TotalSeconds;

            Assert.IsTrue(diff > 10, string.Format("It's be impossible to send 15 requests in {0}s", diff));
        }
    }
}
