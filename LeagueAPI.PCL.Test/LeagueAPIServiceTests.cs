using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using PortableLeagueApi.Core.Enums;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.League.Enums;
using PortableLeagueApi.League.Models.League;
using PortableLeagueApi.Stats.Models.Stats;

namespace PortableLeagueAPI.Test
{
    [TestFixture]
    public class LeagueAPIServiceTests
    {
        public LeagueAPIServiceTests()
        {
            // TODO : Don't forget to pass your api key
            LeagueAPI.Init(string.Empty, new FakeResolver());
            LeagueAPI.DefaultRegion = RegionEnum.Euw;
            LeagueAPI.WaitToAvoidRateLimit = true;
        }

        [Test]
        [Category("Champion")]
        public async void GetFreeChampionsTest()
        {
            var freeChampions = await LeagueAPI.Champion.GetChampions(true);
            
            Assert.NotNull(freeChampions);
            Assert.AreEqual(10, freeChampions.Count());
        }

        [Test]
        [Category("Champion")]
        public async void GetChampionsTest()
        {
            var freeChampions = await LeagueAPI.Champion.GetChampions(false);

            Assert.NotNull(freeChampions);
        }

        [Test]
        [Category("Game")]
        public async void GetRecentGamesBySummonerIdTest()
        {
            var result = await LeagueAPI.Game.GetRecentGamesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesChallengerTierLeaguesTest()
        {
            var result = await LeagueAPI.League.RetrievesChallengerTierLeagues(LeagueTypeEnum.RANKED_SOLO_5x5);

            Assert.NotNull(result);
        }

        [Test]
        [Category("League")]
        public async void RetrievesLeaguesEntryDataForSummonerTest()
        {
            List<LeagueItemDto> result;

            try
            {
                result = await LeagueAPI.League.RetrievesLeaguesEntryDataForSummoner(19332836);
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
                result = await LeagueAPI.League.RetrievesLeaguesDataForSummoner(19332836);
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
            var result = await LeagueAPI.Stats.GetPlayerStatsSummariesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Stats")]
        public async void GetRankedStatsSummariesBySummonerIdTest()
        {
            RankedStatsDto result;

            try
            {
                result = await LeagueAPI.Stats.GetRankedStatsSummariesBySummonerId(19332836);
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
            var result = await LeagueAPI.Summoner.GetMasteryPagesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        //[Test]
        //[Category("Summoner")]
        //public async void GetMasteryPagesBySummonerIdsTest()
        //{
        //    var result = await LeagueAPI.Summoner.GetMasteryPagesBySummonerId(new List<long> { 19231046, 19231045 });

        //    Assert.NotNull(result);
        //}

        [Test]
        [Category("Summoner")]
        public async void GetRunePagesBySummonerIdTest()
        {
            var result = await LeagueAPI.Summoner.GetRunePagesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        //[Test]
        //[Category("Summoner")]
        //public async void GetRunePagesBySummonerIdsTest()
        //{
        //    var result = await LeagueAPI.Summoner.GetRunePagesBySummonerId(new List<long> { 19231046, 19231045 });

        //    Assert.NotNull(result);
        //}

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByNameTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerByName("TuC Ølen");

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerById(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByIdsTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerById(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdsTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerNamesById(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerNamesByIdTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerNamesById(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Team")]
        public async void GetTeamsBySummonerIdTest()
        {
            var result = await LeagueAPI.Team.GetTeamsBySummonerId(19231046);

            Assert.NotNull(result);
        }
    }
}
