using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using NUnit.Framework;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Game.Extensions;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.League.Extensions;
using PortableLeagueApi.Static.Extensions;
using PortableLeagueApi.Team.Extensions;

namespace PortableLeagueAPI.Test
{
    [TestFixture]
    public class LeagueAPIServiceTests
    {
        private readonly LeagueApi _leagueAPI;

        private const long SummonerId = 19332836;
        private const string SummonerName = "TuC Ølen";
        private const string TeamId = "TEAM-4b3c8100-91a3-11e3-be7d-782bcb497d6f";

        public LeagueAPIServiceTests() : this(null)
        {
        }

        public LeagueAPIServiceTests(ILeagueApiConfiguration configuration)
        {
            configuration = configuration ??
                            new LeagueApiConfiguration(string.Empty, RegionEnum.Euw, true, new FakeHttpRequestService());

            _leagueAPI = new LeagueApi(configuration);
        }

        [Test]
        [Category("Others")]
        public async void TestRegions()
        {
            if (_leagueAPI.LeagueApiConfiguration.Key != string.Empty)
            {
                foreach (var region in Enum.GetValues(typeof(RegionEnum)).Cast<RegionEnum>())
                {
                    var freeChampions = await _leagueAPI.Champion.GetChampionsAsync(false, region);

                    Assert.NotNull(freeChampions);
                }
            }
        }

        [Test]
        [Category("Others")]
        public async void SourceMappingTestAsync()
        {
            var fromSource1 = await _leagueAPI.Summoner.GetSummonerByNameAsync(SummonerName);
            var otherFromSource1 = await _leagueAPI.Summoner.GetSummonerByIdAsync(19231046);

            var source2 = new LeagueApi(string.Empty, RegionEnum.Na, true, new FakeHttpRequestService());

            var fromSource2 = await source2.Summoner.GetSummonerByNameAsync(SummonerName);

            Assert.IsNotNull(fromSource1.ApiConfiguration);
            Assert.IsNotNull(otherFromSource1.ApiConfiguration);
            Assert.IsNotNull(fromSource2.ApiConfiguration);
            Assert.AreNotEqual(fromSource1.ApiConfiguration, fromSource2.ApiConfiguration);
            Assert.AreEqual(fromSource1.ApiConfiguration, otherFromSource1.ApiConfiguration);
        }

        [Test]
        [Category("Champion")]
        public async void GetFreeChampionsTestAsync()
        {
            var freeChampions = await _leagueAPI.Champion.GetChampionsAsync(true);
            
            Assert.NotNull(freeChampions);
            Assert.AreEqual(10, freeChampions.Count());
        }

        [Test]
        [Category("Champion")]
        public async void GetChampionsTestAsync()
        {
            var freeChampions = await _leagueAPI.Champion.GetChampionsAsync(false);

            Assert.NotNull(freeChampions);
        }

        [Test]
        [Category("Game")]
        public async void GetRecentGamesBySummonerIdTestAsync()
        {
            var result = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(SummonerId);

            var list = result.ToList();

            Assert.NotNull(result);
            Assert.NotNull(list);
        }

        [Test]
        [Category("Game")]
        public async void GetSummonerAndRecentGamesTestAsync()
        {
            var summoner = await _leagueAPI.Summoner.GetSummonerByNameAsync(SummonerName);

            Assert.NotNull(summoner);

            var result = await summoner.GetRecentGamesAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesChallengerTierLeaguesTestAsync()
        {
            var result = await _leagueAPI.League.RetrievesChallengerTierLeaguesAsync(LeagueTypeEnum.RankedSolo5X5);
            
            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesEntryDataForSummonerTestAsync()
        {
            List<ILeague> result = null;

            try
            {
                var enumerable = await _leagueAPI.League.RetrievesLeaguesEntryDataForSummonerAsync(SummonerId);
                result = enumerable.ToList();
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Assert.Fail("Unranked player. Please update test"); 
            }

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesDataForSummonerTestAsync()
        {
            List<ILeague> result = null;

            try
            {
                var enumerable = await _leagueAPI.League.RetrievesLeaguesDataForSummonerAsync(SummonerId);
                result = enumerable.ToList();
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Assert.Fail("Unranked player. Please update test"); 
            }

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesEntryDataForTeamTestAsync()
        {
            List<ILeague> result = null;

            try
            {
                var enumerable = await _leagueAPI.League.RetrievesLeaguesEntryDataForTeamAsync(TeamId);
                result = enumerable.ToList();
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Assert.Fail("Unranked team. Please update test"); 
            }

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesDataForTeamTestAsync()
        {
            List<ILeague> result = null;

            try
            {
                var enumerable = await _leagueAPI.League.RetrievesLeaguesDataForTeamAsync(TeamId);
                result = enumerable.ToList();
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Assert.Fail("Unranked team. Please update test"); 
            }

            Assert.NotNull(result);
        }
        
        [Test]
        [Category("League")]
        public async void RetrieveLeaguesEntryDataTestAsync()
        {
            var summoner = await _leagueAPI.Summoner.GetSummonerByNameAsync(SummonerName);

            Assert.NotNull(summoner);

            var result = await summoner.RetrieveLeaguesEntryDataAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Stats")]
        public async void GetPlayerStatsSummariesBySummonerIdTestAsync()
        {
            var result = await _leagueAPI.Stats.GetPlayerStatsSummariesBySummonerIdAsync(SummonerId);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Stats")]
        public async void GetRankedStatsSummariesBySummonerIdTestAsync()
        {
            IRankedStats result = null;

            try
            {
                result = await _leagueAPI.Stats.GetRankedStatsSummariesBySummonerIdAsync(SummonerId);
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Assert.Fail("Unranked player. Please update test"); 
            }

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetMasteryPagesBySummonerIdTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetMasteryPagesBySummonerIdAsync(SummonerId);

            Assert.NotNull(result);
        }

        //[Test]
        //[Category("Summoner")]
        //public async void GetMasteryPagesBySummonerIdsTest()
        //{
        //    var result = await _leagueAPI.Summoner.GetMasteryPagesBySummonerIdAsync(new List<long> { 19231046, 19231045 });

        //    Assert.NotNull(result);
        //}

        [Test]
        [Category("Summoner")]
        public async void GetRunePagesBySummonerIdTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetRunePagesBySummonerIdAsync(SummonerId);

            Assert.NotNull(result);
        }

        //[Test]
        //[Category("Summoner")]
        //public async void GetRunePagesBySummonerIdsTest()
        //{
        //    var result = await _leagueAPI.Summoner.GetRunePagesBySummonerIdAsync(new List<long> { 19231046, 19231045 });

        //    Assert.NotNull(result);
        //}

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByNameTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetSummonerByNameAsync(SummonerName);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetSummonerByIdAsync(SummonerId);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdsTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetSummonerByIdAsync(new List<long> { SummonerId, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdsTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetSummonerNamesByIdAsync(new List<long> { SummonerId, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetSummonerNamesByIdAsync(SummonerId);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Team")]
        public async void GetTeamsBySummonerIdTestAsync()
        {
            var result = await _leagueAPI.Team.GetTeamsBySummonerIdAsync(SummonerId);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Team")]
        public async void GetTeamsBySummonerIdExtensionTestAsync()
        {
            var summoner = await _leagueAPI.Summoner.GetSummonerByNameAsync(SummonerName);

            Assert.NotNull(summoner);

            var teams = summoner.GetTeamsBySummonerIdAsync();

            Assert.NotNull(teams);
        }

        [Test]
        [Category("Team")]
        public async void GetTeamsByTeamIdsTestAsync()
        {
            var result = await _leagueAPI.Team.GetTeamsByTeamIdsAsync(new []
            {
                "TEAM-1dc55d56-c3d7-471c-8b28-3f21b5d99582",
                "TEAM-d9ecabd1-7315-11e2-b227-782bcb497d6f"
            });

            Assert.NotNull(result);
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
        public async void GetStaticChampionsTest2Async()
        {
            var result = await _leagueAPI.Static.GetChampionsAsync(true);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticChampionsWithParametersTestAsync()
        {
            var result = await _leagueAPI.Static.GetChampionAsync(13, ChampDataEnum.Info | ChampDataEnum.Image, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
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
            var result = await _leagueAPI.Static.GetSummonerSpellsAsync(12, SpellDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticSummonerSpellsWithParametersTest2Async()
        {
            var result = await _leagueAPI.Static.GetSummonerSpellsAsync(true, SpellDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetVersionsTestAsync()
        {
            var versions = await _leagueAPI.Static.GetVersionsAsync();
            Assert.NotNull(versions);
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
                var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));

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
                    var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));

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
                var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));

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
                    var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));

                    Assert.IsTrue(response.IsSuccessStatusCode);
                }
            }
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
        public async void GetChampionImageUrlTestAsync()
        {
            var champion = await _leagueAPI.Static.GetChampionAsync(13, ChampDataEnum.All, languageCode: LanguageEnum.French);
            Assert.NotNull(champion);

            var result = await champion.GetChampionImageUrlAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void GetSpriteUrlTestAsync()
        {
            var champion = await _leagueAPI.Static.GetChampionAsync(13, ChampDataEnum.All, languageCode: LanguageEnum.French);
            Assert.NotNull(champion);

            var result = await champion.Image.GetSpriteUrlAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void MasteryExtensionsTestAsync()
        {
            var masteriesPage = await _leagueAPI.Summoner.GetMasteryPagesBySummonerIdAsync(SummonerId);
            Assert.NotNull(masteriesPage);

            var result = await masteriesPage.First().Masteries.First().GetMasteryStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void RuneExtensionsTestAsync()
        {
            var runesPages = await _leagueAPI.Summoner.GetRunePagesBySummonerIdAsync(SummonerId);
            Assert.NotNull(runesPages);

            var result = await runesPages.First().Slots.First().GetRuneStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void ItemsExtensionsTestAsync()
        {
            var recentGames = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(SummonerId);
            Assert.NotNull(recentGames);

            var result = await recentGames.First().Stats.GetItemsStaticInfosAsync();

            Assert.NotNull(result);
        }

        [Test]
        [Category("StaticExtensions")]
        public async void ItemsImageExtensionsTestAsync()
        {
            var recentGames = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(SummonerId);
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
            var recentGames = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(SummonerId);
            Assert.NotNull(recentGames);

            var result = await recentGames.First().GetSummonerSpellsStaticInfosAsync();

            Assert.NotNull(result);
        }

    }
}
