using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using PortableLeagueAPI;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Game.Services;
using PortableLeagueApi.League.Enums;
using PortableLeagueApi.League.Models.League;
using PortableLeagueApi.Stats.Models.Stats;
using PortableLeagueAPI.Test;

namespace PortableLeagueApi.Test
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
        [Category("Champion")]
        public async void GetFreeChampionsTest()
        {
            var freeChampions = await _leagueAPI.Champion.GetChampions(true);
            
            Assert.NotNull(freeChampions);
            Assert.AreEqual(10, freeChampions.Count());
        }

        [Test]
        [Category("Champion")]
        public async void GetChampionsTest()
        {
            var freeChampions = await _leagueAPI.Champion.GetChampions(false);

            Assert.NotNull(freeChampions);
        }

        [Test]
        [Category("Game")]
        public async void GetRecentGamesBySummonerIdTest()
        {
            var result = await _leagueAPI.Game.GetRecentGamesBySummonerId(19231046);

            Assert.NotNull(result);
        }


        [Test]
        [Category("Game")]
        public async void GetSummonerAndRecentGamesTest()
        {
            var summoner = await _leagueAPI.Summoner.GetSummonerByName("TuC Ølen");

            Assert.NotNull(summoner);

            var result = await summoner.GetRecentGames(_leagueAPI.Game);

            Assert.NotNull(result);
        }


        [Test]
        [Category("League")]
        public async void RetrievesChallengerTierLeaguesTest()
        {
            var result = await _leagueAPI.League.RetrievesChallengerTierLeagues(LeagueTypeEnum.RANKED_SOLO_5x5);

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesEntryDataForSummonerTest()
        {
            List<LeagueItemDto> result;

            try
            {
                result = await _leagueAPI.League.RetrievesLeaguesEntryDataForSummoner(19332836);
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
            List<LeagueDto> result;

            try
            {
                result = await _leagueAPI.League.RetrievesLeaguesDataForSummoner(19332836);
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
            var result = await _leagueAPI.Stats.GetPlayerStatsSummariesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Stats")]
        public async void GetRankedStatsSummariesBySummonerIdTest()
        {
            RankedStatsDto result;

            try
            {
                result = await _leagueAPI.Stats.GetRankedStatsSummariesBySummonerId(19332836);
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
            var result = await _leagueAPI.Summoner.GetMasteryPagesBySummonerId(19332836);

            Assert.NotNull(result);
        }

        //[Test]
        //[Category("Summoner")]
        //public async void GetMasteryPagesBySummonerIdsTest()
        //{
        //    var result = await _leagueAPI.Summoner.GetMasteryPagesBySummonerId(new List<long> { 19231046, 19231045 });

        //    Assert.NotNull(result);
        //}

        [Test]
        [Category("Summoner")]
        public async void GetRunePagesBySummonerIdTest()
        {
            var result = await _leagueAPI.Summoner.GetRunePagesBySummonerId(19332836);

            Assert.NotNull(result);
        }

        //[Test]
        //[Category("Summoner")]
        //public async void GetRunePagesBySummonerIdsTest()
        //{
        //    var result = await _leagueAPI.Summoner.GetRunePagesBySummonerId(new List<long> { 19231046, 19231045 });

        //    Assert.NotNull(result);
        //}

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByNameTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerByName("TuC Ølen");

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerById(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdsTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerById(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdsTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerNamesById(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdTest()
        {
            var result = await _leagueAPI.Summoner.GetSummonerNamesById(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Team")]
        public async void GetTeamsBySummonerIdTest()
        {
            var result = await _leagueAPI.Team.GetTeamsBySummonerId(19231046);

            Assert.NotNull(result);
        }
    }
}
