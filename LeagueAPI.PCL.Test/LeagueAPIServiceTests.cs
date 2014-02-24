using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Game;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.Interfaces.Stats;

namespace PortableLeagueAPI.Test
{
    [TestFixture]
    public class LeagueAPIServiceTests
    {
        private readonly LeagueAPI _leagueAPI;

        public LeagueAPIServiceTests()
        {

            _leagueAPI = new LeagueAPI(string.Empty, RegionEnum.Euw, true, new FakeHttpRequestService());
        }

        [Test]
        [Category("Others")]
        public async void SourceMappingTestAsync()
        {
            var fromSource1 = await _leagueAPI.Summoner.GetSummonerByNameAsync("TuC Ølen");
            var otherFromSource1 = await _leagueAPI.Summoner.GetSummonerByIdAsync(19231046);

            var source2 = new LeagueAPI(string.Empty, RegionEnum.Euw, true, new FakeHttpRequestService());

            var fromSource2 = await source2.Summoner.GetSummonerByNameAsync("TuC Ølen");

            Assert.AreNotEqual(fromSource1.Source, fromSource2.Source);
            Assert.AreEqual(fromSource1.Source, _leagueAPI);
            Assert.AreEqual(fromSource2.Source, source2);
            Assert.AreEqual(fromSource1.Source, otherFromSource1.Source);
        }

        [Test]
        [Category("Champion")]
        public async void GetFreeChampionsTest()
        {
            var freeChampions = await _leagueAPI.Champion.GetChampionsAsync(true);
            
            Assert.NotNull(freeChampions);
            Assert.AreEqual(10, freeChampions.Count());
        }

        [Test]
        [Category("Champion")]
        public async void GetChampionsTest()
        {
            var freeChampions = await _leagueAPI.Champion.GetChampionsAsync(false);

            Assert.NotNull(freeChampions);
        }

        [Test]
        [Category("Game")]
        public async void GetRecentGamesBySummonerIdTest()
        {
            var result = await _leagueAPI.Game.GetRecentGamesBySummonerIdAsync(19231046);

            var list = result.ToList();

            Assert.NotNull(result);
            Assert.NotNull(list);
        }

        [Test]
        [Category("Game")]
        public async void GetSummonerAndRecentGamesTest()
        {
            var summoner = await _leagueAPI.Summoner.GetSummonerByNameAsync("TuC Ølen");

            Assert.NotNull(summoner);

            var result = await summoner.GetRecentGames();

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesChallengerTierLeaguesTest()
        {
            var result = await _leagueAPI.League.RetrievesChallengerTierLeaguesAsync(LeagueTypeEnum.RankedSolo5X5);
            
            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesEntryDataForSummonerTest()
        {
            List<ILeagueItem> result;

            try
            {
                var enumerable = await _leagueAPI.League.RetrieveLeaguesEntryDataForSummonerAsync(19332836);
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
        public async void RetrievesLeaguesDataForSummonerTest()
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
        [Category("Stats")]
        public async void GetPlayerStatsSummariesBySummonerIdTest()
        {
            var result = await _leagueAPI.Stats.GetPlayerStatsSummariesBySummonerIdAsync(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Stats")]
        public async void GetRankedStatsSummariesBySummonerIdTest()
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
        public async void GetMasteryPagesBySummonerIdTest()
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
        public async void GetRunePagesBySummonerIdTest()
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
        public async void GetSummonerByNameTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerByNameAsync("TuC Ølen");

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerByIdAsync(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdsTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerByIdAsync(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdsTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerNamesByIdAsync(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerNamesByIdAsync(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Team")]
        public async void GetTeamsBySummonerIdTest()
        {
            var result = await _leagueAPI.Team.GetTeamsBySummonerIdAsync(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Team")]
        public async void GetTeamsByTeamIdsTest()
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
