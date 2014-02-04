using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Exceptions;
using PortableLeagueAPI.Models.League;
using PortableLeagueAPI.Models.Stats;

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
            List<LeagueDto> result;

            try
            {
                result = await LeagueAPI.League.GetLeagueInfosBySummonerId(19332836);
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

        [Test]
        [Category("Static")]
        public async void GetStaticChampionsTest()
        {
            var result = await LeagueAPI.Static.GetChampions();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticChampionsWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetChampions(13, ChampDataEnum.All, languageCode:LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticItemsTest()
        {
            var result = await LeagueAPI.Static.GetItems();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticItemsWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetItems(1001, ItemDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticMasteriesTest()
        {
            var result = await LeagueAPI.Static.GetMasteries();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticMasteriesWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetMasteries(4353, MasteryDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetRealm()
        {
            var result = await LeagueAPI.Static.GetRealm();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticRunesTest()
        {
            var result = await LeagueAPI.Static.GetRunes();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticRunesWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetRunes(5235, RuneDataEnum.All, languageCode: LanguageEnum.French);

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticSummonerSpellsTest()
        {
            var result = await LeagueAPI.Static.GetSummonerSpells();

            Assert.NotNull(result);
        }

        [Test]
        [Category("Static")]
        public async void GetStaticSummonerSpellsWithParametersTest()
        {
            var result = await LeagueAPI.Static.GetSummonerSpells("SummonerBattleCry", SpellDataEnum.All, languageCode: LanguageEnum.French);

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
