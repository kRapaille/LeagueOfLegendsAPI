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
        public OnlineLeagueAPIServiceTests()
        {
            // TODO : Don't forget to pass your api key
            LeagueAPI.Init(string.Empty);
            LeagueAPI.DefaultRegion = RegionEnum.Euw;
            LeagueAPI.WaitToAvoidRateLimit = true;
        }

        [Test]
        [Category("Static")]
        public async void GetStaticChampionsTest()
        {
            var result = await LeagueAPI.Static.GetChampions();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void CacheTest()
        {
            var sw = new Stopwatch();
            sw.Start();

            var result = await LeagueAPI.Static.GetChampions();
            
            sw.Stop();
            var firstTime = sw.ElapsedMilliseconds;
            sw.Restart();

            var result2 = await LeagueAPI.Static.GetChampions();

            sw.Stop();
            var secondTime = sw.ElapsedMilliseconds;

            Assert.NotNull(result);
            Assert.NotNull(result2);
            Assert.Greater(firstTime, secondTime);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticChampionsWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetChampion(13, ChampDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticItemsTest()
        {
            var result = await LeagueAPI.Static.GetItems();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticItemsWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetItems(1001, ItemDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticMasteriesTest()
        {
            var result = await LeagueAPI.Static.GetMasteries();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticMasteriesWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetMastery(4353, MasteryDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetRealm()
        {
            var result = await LeagueAPI.Static.GetRealm();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticRunesTest()
        {
            var result = await LeagueAPI.Static.GetRunes();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticRunesWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetRune(5235, RuneDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticSummonerSpellsTest()
        {
            var result = await LeagueAPI.Static.GetSummonerSpells();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticSummonerSpellsWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetSummonerSpells("SummonerTeleport", SpellDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void ChampionExtensionsTest()
        {
            var champions = await LeagueAPI.Champion.GetChampions(true);
            Assert.NotNull(champions);

            var result = await champions.First().GetChampionStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void MasteryExtensionsTest()
        {
            var masteriesPage = await LeagueAPI.Summoner.GetMasteryPagesBySummonerId(19231046);
            Assert.NotNull(masteriesPage);

            var result = await masteriesPage.First().Talents.First().GetMasteryStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void RuneExtensionsTest()
        {
            var runesPages = await LeagueAPI.Summoner.GetRunePagesBySummonerId(19231046);
            Assert.NotNull(runesPages);

            var result = await runesPages.First().Slots.First().Rune.GetRuneStaticInfos();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void ItemsExtensionsTest()
        {
            var recentGames = await LeagueAPI.Game.GetRecentGamesBySummonerId(19231046);
            Assert.NotNull(recentGames);

            var result = await recentGames.First().Stats.GetItemsStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void SummonerSpellExtensionsTest()
        {
            var recentGames = await LeagueAPI.Game.GetRecentGamesBySummonerId(19231046);
            Assert.NotNull(recentGames);

            var result = await recentGames.First().GetSummonerSpellsStaticInfosAsync();

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
                await LeagueAPI.Champion.GetChampions(true);
            }

            var diff = DateTime.Now.Subtract(start).TotalSeconds;

            Assert.IsTrue(diff > 10, string.Format("It's be impossible to send 15 requests in {0}s", diff));
        }
    }
}
