using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using LeagueAPI.PCL.Models.Enum;
using LeagueAPI.PCL.Models.Exceptions;
using NUnit.Framework;

namespace LeagueAPI.PCL.Test
{
    [TestFixture]
    public class LeagueAPIServiceTests
    {
        private readonly LeagueAPIService _leagueAPIService;
        public LeagueAPIServiceTests()
        {
            // TODO : Don't forget to pass your api key
            _leagueAPIService = new LeagueAPIService(string.Empty, RegionEnum.Euw);
        }

        [Test]
        public async void APIKeyErrorTest()
        {
            // Let API Key empty here
            var api = new LeagueAPIService(string.Empty, RegionEnum.Euw);
            try
            {
                await api.GetChampions(true);

                Assert.Fail("Exception didn't throw");
            }
            catch (APIRequestException are)
            {
                Debug.WriteLine(are.Message);
            }
        }

        [Test]
        public async void GetFreeChampionsTest()
        {
            var freeChampions = await _leagueAPIService.GetChampions(true);
            
            Assert.NotNull(freeChampions);
            Assert.AreEqual(10, freeChampions.Count());
        }

        [Test]
        public async void GetChampionsTest()
        {
            var freeChampions = await _leagueAPIService.GetChampions(false);

            Assert.NotNull(freeChampions);
        }

        [Test]
        public async void GetRecentGamesBySummonerIdTest()
        {
            var result = await _leagueAPIService.GetRecentGamesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetLeagueInfosBySummonerIdTest()
        {
            var result = await _leagueAPIService.GetLeagueInfosBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetPlayerStatsSummariesBySummonerIdTest()
        {
            var result = await _leagueAPIService.GetPlayerStatsSummariesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetRankedStatsSummariesBySummonerIdTest()
        {
            var result = await _leagueAPIService.GetRankedStatsSummariesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetMasteryPagesBySummonerIdTest()
        {
            var result = await _leagueAPIService.GetMasteryPagesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetRunePagesBySummonerIdTest()
        {
            var result = await _leagueAPIService.GetRunePagesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetSummonerByNameTest()
        {
            var result = await _leagueAPIService.GetSummonerByName("TuC Kiwii");

            Assert.NotNull(result);
        }

        [Test]
        public async void GetSummonerByIdTest()
        {
            var result = await _leagueAPIService.GetSummonerById(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetSummonerNamesByIdsTest()
        {
            var result = await _leagueAPIService.GetSummonerNamesByIds(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        public async void GetTeamsBySummonerIdTest()
        {
            var result = await _leagueAPIService.GetTeamsBySummonerId(19231046);

            Assert.NotNull(result);
        }
    }
}
