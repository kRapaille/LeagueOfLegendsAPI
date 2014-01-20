using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Exceptions;
using PortableLeagueAPI.Models.League;

namespace PortableLeagueAPI.Test
{
    [TestFixture]
    public class LeagueAPIServiceTests
    {
        public LeagueAPIServiceTests()
        {
            // TODO : Don't forget to pass your api key
            LeagueAPI.Init(string.Empty);
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
        public async void GetLeagueInfosBySummonerIdTest()
        {
            Dictionary<string, League> result;

            try
            {
                result = await LeagueAPI.League.GetLeagueInfosBySummonerId(19231046);
            }
            catch (APIRequestException are)
            {
                if (are.APIRequestError.Status.StatusCode != 404)
                    throw;

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
            var result = await LeagueAPI.Stats.GetRankedStatsSummariesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetMasteryPagesBySummonerIdTest()
        {
            var result = await LeagueAPI.Summoner.GetMasteryPagesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetMasteryPagesBySummonerIdsTest()
        {
            var result = await LeagueAPI.Summoner.GetMasteryPagesBySummonerId(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetRunePagesBySummonerIdTest()
        {
            var result = await LeagueAPI.Summoner.GetRunePagesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetRunePagesBySummonerIdsTest()
        {
            var result = await LeagueAPI.Summoner.GetRunePagesBySummonerId(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        [Category("Summoner")]
        public async void GetSummonerByNameTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerByName("TuC Kiwii");

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

        [Test]
        [Category("Static")]
        public async void GetItemsTest()
        {
            var result = await LeagueAPI.Static.GetItems();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetRunesTest()
        {
            var result = await LeagueAPI.Static.GetRunes();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetMasteriesTest()
        {
            var result = await LeagueAPI.Static.GetMasteries();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetSummonersTest()
        {
            var result = await LeagueAPI.Static.GetSummoners();

            Assert.NotNull(result);
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
        public async void GetProfileIconsTest()
        {
            var result = await LeagueAPI.Static.GetProfileIcons();
            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetLanguagesTest()
        {
            var result = await LeagueAPI.Static.GetLanguages();

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
