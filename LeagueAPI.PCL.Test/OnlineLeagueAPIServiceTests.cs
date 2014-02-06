using System;
using System.Diagnostics;
using NUnit.Framework;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Static.Enums;

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
        public async void GetStaticChampionsWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetChampions(13, ChampDataEnum.All, languageCode: LanguageEnum.French);

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
            var result = await LeagueAPI.Static.GetMasteries(4353, MasteryDataEnum.All, languageCode: LanguageEnum.French);

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
            var result = await LeagueAPI.Static.GetRunes(5235, RuneDataEnum.All, languageCode: LanguageEnum.French);

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
