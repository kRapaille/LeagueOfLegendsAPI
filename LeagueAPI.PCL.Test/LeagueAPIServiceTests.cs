using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PortableLeagueAPI.Models.Enums;

namespace PortableLeagueAPI.Test
{
    [TestFixture]
    public class LeagueAPIServiceTests
    {
        public LeagueAPIServiceTests()
        {
            // TODO : Don't forget to pass your api key
            LeagueAPI.Init(string.Empty);
            LeagueAPI.SetDefaultRegion(RegionEnum.Euw);
        }

        [Test]
        public async void GetFreeChampionsTest()
        {
            var freeChampions = await LeagueAPI.Champion.GetChampions(true);
            
            Assert.NotNull(freeChampions);
            Assert.AreEqual(10, freeChampions.Count());
        }

        [Test]
        public async void GetChampionsTest()
        {
            var freeChampions = await LeagueAPI.Champion.GetChampions(false);

            Assert.NotNull(freeChampions);
        }

        [Test]
        public async void GetRecentGamesBySummonerIdTest()
        {
            var result = await LeagueAPI.Game.GetRecentGamesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetLeagueInfosBySummonerIdTest()
        {
            var result = await LeagueAPI.League.GetLeagueInfosBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetLeagueInfosBySummonerIdV2Rev1Test()
        {
            var result = await LeagueAPI.League.GetLeagueInfosBySummonerId(19231046, version:VersionEnum.V2Rev1);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetPlayerStatsSummariesBySummonerIdTest()
        {
            var result = await LeagueAPI.Stats.GetPlayerStatsSummariesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetRankedStatsSummariesBySummonerIdTest()
        {
            var result = await LeagueAPI.Stats.GetRankedStatsSummariesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetMasteryPagesBySummonerIdTest()
        {
            var result = await LeagueAPI.Summoner.GetMasteryPagesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetMasteryPagesBySummonerIdsTest()
        {
            var result = await LeagueAPI.Summoner.GetMasteryPagesBySummonerId(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        public async void GetRunePagesBySummonerIdTest()
        {
            var result = await LeagueAPI.Summoner.GetRunePagesBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetRunePagesBySummonerIdsTest()
        {
            var result = await LeagueAPI.Summoner.GetRunePagesBySummonerId(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        public async void GetSummonerByNameTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerByName("TuC Kiwii");

            Assert.NotNull(result);
        }

        [Test]
        public async void GetSummonerByIdTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerById(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetSummonerNamesByIdsTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerNamesById(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        public async void GetSummonerNamesByIdTest()
        {
            var result = await LeagueAPI.Summoner.GetSummonerNamesById(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetTeamsBySummonerIdTest()
        {
            var result = await LeagueAPI.Team.GetTeamsBySummonerId(19231046);

            Assert.NotNull(result);
        }

        [Test]
        public async void GetItemsTest()
        {
            var result = await LeagueAPI.Static.GetItems();

            Assert.NotNull(result);
        }

        [Test]
        public async void GetRunesTest()
        {
            var result = await LeagueAPI.Static.GetRunes();

            Assert.NotNull(result);
        }

        [Test]
        public async void GetMasteriesTest()
        {
            var result = await LeagueAPI.Static.GetMasteries();

            Assert.NotNull(result);
        }

        [Test]
        public async void GetSummonersTest()
        {
            var result = await LeagueAPI.Static.GetSummoners();

            Assert.NotNull(result);
        }

        [Test]
        public async void GetStaticChampionsTest()
        {
            var result = await LeagueAPI.Static.GetChampions();

            Assert.NotNull(result);
        }

        [Test]
        public async void GetProfileIconsTest()
        {
            var result = await LeagueAPI.Static.GetProfileIcons();
            Assert.NotNull(result);
        }

        [Test]
        public async void GetLanguagesTest()
        {
            var result = await LeagueAPI.Static.GetLanguages();

            Assert.NotNull(result);
        }
    }
}
