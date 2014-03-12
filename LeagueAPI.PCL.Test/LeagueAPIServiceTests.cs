using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Game.Extensions;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.Interfaces.Stats;

namespace PortableLeagueAPI.Test
{
    [TestFixture]
    public class LeagueAPIServiceTests
    {
        private readonly LeagueApi _leagueAPI;

        public LeagueAPIServiceTests()
        {
            _leagueAPI = new LeagueApi(string.Empty, RegionEnum.Euw, true, new FakeHttpRequestService());
        }

        [Test]
        [Category("Others")]
        public async void SourceMappingTestAsync()
        {
            var fromSource1 = await _leagueAPI.Summoner.GetSummonerByNameAsync("TuC Ølen");
            var otherFromSource1 = await _leagueAPI.Summoner.GetSummonerByIdAsync(19231046);

            var source2 = new LeagueApi(string.Empty, RegionEnum.Euw, true, new FakeHttpRequestService());

            var fromSource2 = await source2.Summoner.GetSummonerByNameAsync("TuC Ølen");

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
            var result = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(19231046);

            var list = result.ToList();

            Assert.NotNull(result);
            Assert.NotNull(list);
        }

        [Test]
        [Category("Game")]
        public async void GetSummonerAndRecentGamesTestAsync()
        {
            var summoner = await _leagueAPI.Summoner.GetSummonerByNameAsync("TuC Ølen");

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
            List<ILeagueItem> result;

            try
            {
                var enumerable = await _leagueAPI.League.RetrievesLeaguesEntryDataForSummonerAsync(19332836);
                result = enumerable.ToList();
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Debug.WriteLine("Unranked player");

                return;
            }

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesDataForSummonerTestAsync()
        {
            List<ILeague> result;

            try
            {
                var enumerable = await _leagueAPI.League.RetrievesLeaguesDataForSummonerAsync(19332836);
                result = enumerable.ToList();
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Debug.WriteLine("Unranked player");

                return;
            }

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesEntryDataForTeamTestAsync()
        {
            List<ILeagueItem> result;

            try
            {
                var enumerable = await _leagueAPI.League.RetrievesLeaguesEntryDataForTeamAsync("TEAM-4b3c8100-91a3-11e3-be7d-782bcb497d6f");
                result = enumerable.ToList();
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Debug.WriteLine("Unranked team");

                return;
            }

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesDataForTeamTestAsync()
        {
            List<ILeague> result;

            try
            {
                var enumerable = await _leagueAPI.League.RetrievesLeaguesDataForTeamAsync("TEAM-4b3c8100-91a3-11e3-be7d-782bcb497d6f");
                result = enumerable.ToList();
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Debug.WriteLine("Unranked team");

                return;
            }

            Assert.NotNull(result);
        }

        [Test]
        [Category("Stats")]
        public async void GetPlayerStatsSummariesBySummonerIdTestAsync()
        {
            var result = await _leagueAPI.Stats.GetPlayerStatsSummariesBySummonerIdAsync(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Stats")]
        public async void GetRankedStatsSummariesBySummonerIdTestAsync()
        {
            IRankedStats result;

            try
            {
                result = await _leagueAPI.Stats.GetRankedStatsSummariesBySummonerIdAsync(19332836);
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.StatusCode != 404)
                    throw;

                Debug.WriteLine("Player unranked");

                return;
            }

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetMasteryPagesBySummonerIdTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetMasteryPagesBySummonerIdAsync(19332836);

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
            var result = await _leagueAPI.Summoner.GetRunePagesBySummonerIdAsync(19332836);

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
            var result = await _leagueAPI.Summoner.GetSummonerByNameAsync("TuC Ølen");

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetSummonerByIdAsync(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdsTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetSummonerByIdAsync(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdsTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetSummonerNamesByIdAsync(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdTestAsync()
        {
            var result = await _leagueAPI.Summoner.GetSummonerNamesByIdAsync(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Team")]
        public async void GetTeamsBySummonerIdTestAsync()
        {
            var result = await _leagueAPI.Team.GetTeamsBySummonerIdAsync(19231046);

            Assert.NotNull(result);
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
    }
}
