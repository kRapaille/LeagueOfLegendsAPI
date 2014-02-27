using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using NUnit.Framework;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Static.Extensions;

namespace PortableLeagueAPI.Test
{
    [TestFixture]
    public class OnlineLeagueAPIServiceTests
    {
        private readonly LeagueApi _leagueAPI;

        public OnlineLeagueAPIServiceTests()
        {
            // TODO : Don't forget to pass your api key
            _leagueAPI = new LeagueApi(string.Empty, RegionEnum.Euw, true);
        }

        [Test]
        [Category("Static")]
        public async void CacheTestAsync()
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
            Assert.Less(secondTime, 20);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticChampionsTestAsync()
        {
            var result = await _leagueAPI.Static.GetChampionsAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticChampionsWithParametersTestAsync()
        {
            var result = await _leagueAPI.Static.GetChampionAsync(13, ChampDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void GetStaticImageUrlTestAsync()
        {
            var item = await _leagueAPI.Static.GetItemsAsync(1001, ItemDataEnum.All, languageCode: LanguageEnum.French);

            var url = await item.Image.GetUrlAsync();

            Assert.NotNull(url);

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);

                Assert.IsTrue(response.IsSuccessStatusCode);
            }
        }

        [Test]
        [Category("StaticExtensions")]
        public async void GetStaticChampionsSpasheImagesUrlTestAsync()
        {
            var champion = await _leagueAPI.Static.GetChampionAsync(13, ChampDataEnum.All, languageCode: LanguageEnum.French);

            var urls = champion.GetSpasheImmagesUrls();

            Assert.NotNull(urls);

            using (var httpClient = new HttpClient())
            {
                foreach (var url in urls)
                {
                    var response = await httpClient.GetAsync(url);

                    Assert.IsTrue(response.IsSuccessStatusCode);
                }
            }
        }

        [Test]
        [Category("StaticExtensions")]
        public async void GetProfilIconImagesUrlTestAsync()
        {
            var summoner = await _leagueAPI.Summoner.GetSummonerByNameAsync("TuC Kiwii");

            var url = await summoner.GetProfileIconUrlAsync();

            Assert.NotNull(url);

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);

                Assert.IsTrue(response.IsSuccessStatusCode);
            }
        }

        [Test]
        [Category("StaticExtensions")]
        public async void GetStaticChampionsLoadingImagesUrlTestAsync()
        {
            var champion = await _leagueAPI.Static.GetChampionAsync(13, ChampDataEnum.All, languageCode: LanguageEnum.French);

            var urls = champion.GetLoadingImagesUrls();

            Assert.NotNull(urls);

            using (var httpClient = new HttpClient())
            {
                foreach (var url in urls)
                {
                    var response = await httpClient.GetAsync(url);

                    Assert.IsTrue(response.IsSuccessStatusCode);
                }
            }
        }

        [Test]
        [Category("Static")]
        public async void GetStaticItemsTestAsync()
        {
            var result = await _leagueAPI.Static.GetItemsAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticItemsWithParametersTestAsync()
        {
            var result = await _leagueAPI.Static.GetItemsAsync(1001, ItemDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticMasteriesTestAsync()
        {
            var result = await _leagueAPI.Static.GetMasteriesAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticMasteriesWithParametersTestAsync()
        {
            var result = await _leagueAPI.Static.GetMasteryAsync(4353, MasteryDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetRealmAsync()
        {
            var result = await _leagueAPI.Static.GetRealmAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticRunesTestAsync()
        {
            var result = await _leagueAPI.Static.GetRunesAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticRunesWithParametersTestAsync()
        {
            var result = await _leagueAPI.Static.GetRuneAsync(5235, RuneDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticSummonerSpellsTestAsync()
        {
            var result = await _leagueAPI.Static.GetSummonerSpellsAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticSummonerSpellsWithParametersTestAsync()
        {
            var result = await _leagueAPI.Static.GetSummonerSpellsAsync("SummonerTeleport", SpellDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void ChampionExtensionsTestAsync()
        {
            var champions = await _leagueAPI.Champion.GetChampionsAsync(true);
            Assert.NotNull(champions);

            var result = await champions.First().GetChampionStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void MasteryExtensionsTestAsync()
        {
            var masteriesPage = await _leagueAPI.Summoner.GetMasteryPagesBySummonerIdAsync(19231046);
            Assert.NotNull(masteriesPage);

            var result = await masteriesPage.First().Talents.First().GetMasteryStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void RuneExtensionsTestAsync()
        {
            var runesPages = await _leagueAPI.Summoner.GetRunePagesBySummonerIdAsync(19231046);
            Assert.NotNull(runesPages);

            var result = await runesPages.First().Slots.First().Rune.GetRuneStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void ItemsExtensionsTestAsync()
        {
            var recentGames = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(19231046);
            Assert.NotNull(recentGames);

            var result = await recentGames.First().Stats.GetItemsStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void ItemsImageExtensionsTestAsync()
        {
            var recentGames = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(19231046);
            Assert.NotNull(recentGames);

            var urls = await recentGames.First().Stats.GetItemsImageUrlsAsync();
            Assert.NotNull(urls);

            using (var httpClient = new HttpClient())
            {
                foreach (var url in urls)
                {
                    var response = await httpClient.GetAsync(url);

                    Assert.IsTrue(response.IsSuccessStatusCode);
                }
            }

            Assert.NotNull(urls);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void SummonerSpellExtensionsTestAsync()
        {
            var recentGames = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(19231046);
            Assert.NotNull(recentGames);

            var result = await recentGames.First().GetSummonerSpellsStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Others")]
        public async void TenSecRateLimitTestAsync()
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
