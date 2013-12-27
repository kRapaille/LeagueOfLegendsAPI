using System.Collections.Generic;
using System.Linq;
using LeagueAPI.PCL.Models.Enums;
using NUnit.Framework;

namespace LeagueAPI.PCL.Test
{
    [TestFixture]
    public class LeagueAPIServiceTests
    {
        public LeagueAPIServiceTests()
        {
            // TODO : Don't forget to pass your api key
            LeagueAPI.Init("YOU KEY HERE");
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
        public async void GetRunePagesBySummonerIdTest()
        {
            var result = await LeagueAPI.Summoner.GetRunePagesBySummonerId(19231046);

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
            var result = await LeagueAPI.Summoner.GetSummonerNamesByIds(new List<long> { 19231046, 19231045 });

            Assert.NotNull(result);
        }

        [Test]
        public async void GetTeamsBySummonerIdTest()
        {
            var result = await LeagueAPI.Team.GetTeamsBySummonerId(19231046);

            Assert.NotNull(result);
        }
    }
}
