using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LeagueAPI.PCL.Models;
using LeagueAPI.PCL.Models.Enum;
using LeagueAPI.PCL.Models.Exceptions;
using Newtonsoft.Json;

namespace LeagueAPI.PCL
{
    public class LeagueAPIService
    {
        private readonly string _key;

        private const string BaseURL = "https://prod.api.pvp.net/api/";
        private readonly RegionEnum _region;

        public LeagueAPIService(string key, RegionEnum region)
        {
            _key = key;
            _region = region;
        }

        private async Task<T> SendRequest<T>(string operationURL, bool hasOtherQueryParamaters = false) where T : class
        {
            var apiKeyPrefix = hasOtherQueryParamaters ? "&" : "?";

            var url = string.Concat(BaseURL, operationURL, apiKeyPrefix, string.Format("api_key={0}", _key));

            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await httpClient.SendAsync(request);

            T result;

            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<T>(content);
            }
            else
            {
                Debug.WriteLine(url);

                var apiRequestError = JsonConvert.DeserializeObject<APIRequestError>(content);
                throw new APIRequestException(apiRequestError, url);
            }

            return result;
        }

        private string GetRegion(RegionEnum? region)
        {
            return (region.HasValue ? region : _region).ToString().ToLower();
        }

        public async Task<IEnumerable<Champion>> GetChampions(
            bool freeToPlay,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/champion?freeToPlay={1}", GetRegion(region), freeToPlay);

            var championsRoot = await SendRequest<ChampionsRoot>(url, true);

            return championsRoot.Champions.AsEnumerable();
        }

        public async Task<IEnumerable<Game>> GetRecentGamesBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/game/by-summoner/{1}/recent", GetRegion(region), summonerId);

            var recentGamesRoot = await SendRequest<RecentGamesRoot>(url);

            return recentGamesRoot.Games.AsEnumerable();
        }

        public async Task<Dictionary<string, LeagueInfo>> GetLeagueInfosBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/v2.1/league/by-summoner/{1}", GetRegion(region), summonerId);

            return await SendRequest<Dictionary<string, LeagueInfo>>(url);
        }

        public async Task<IEnumerable<PlayerStatSummary>> GetPlayerStatsSummariesBySummonerId(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/stats/by-summoner/{1}/summary", GetRegion(region), summonerId);

            var hasOtherQueryParamaters = false;
            if (season.HasValue)
            {
                url += string.Concat("?season=", season.ToString().ToUpper());
                hasOtherQueryParamaters = true;
            }

            var playerStatSummaryRoot = await SendRequest<PlayerStatSummaryRoot>(url, hasOtherQueryParamaters);

            return playerStatSummaryRoot.PlayerStatSummaries.AsEnumerable();
        }

        public async Task<RankedStats> GetRankedStatsSummariesBySummonerId(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/stats/by-summoner/{1}/ranked", GetRegion(region), summonerId);

            var hasOtherQueryParamaters = false;
            if (season.HasValue)
            {
                url += string.Concat("?season=", season.ToString().ToUpper());
                hasOtherQueryParamaters = true;
            }

            var rankedStatsRoot = await SendRequest<RankedStats>(url, hasOtherQueryParamaters);

            return rankedStatsRoot;
        }

        public async Task<IEnumerable<MasteryPage>> GetMasteryPagesBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/summoner/{1}/masteries", GetRegion(region), summonerId);

            var masteryPagesRoot = await SendRequest<MasteryPagesRoot>(url);

            return masteryPagesRoot.Pages.AsEnumerable();
        }

        public async Task<IEnumerable<RunePage>> GetRunePagesBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/summoner/{1}/runes", GetRegion(region), summonerId);

            var runePageRoot = await SendRequest<RunePageRoot>(url);

            return runePageRoot.Pages.AsEnumerable();
        }

        public async Task<Summoner> GetSummonerByName(string name, RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/summoner/by-name/{1}", GetRegion(region), name);

            return await SendRequest<Summoner>(url);
        }

        public async Task<Summoner> GetSummonerById(long summonerId, RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/summoner/{1}", GetRegion(region), summonerId);

            return await SendRequest<Summoner>(url);
        }

        public async Task<IEnumerable<SummonerInfos>> GetSummonerNamesByIds(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/summoner/{1}/name", GetRegion(region), string.Join(",", summonerIds));

            var summonerInfosRoot = await SendRequest<SummonerInfosRoot>(url);

            return summonerInfosRoot.Summoners.AsEnumerable();
        }

        public async Task<IEnumerable<Team>> GetTeamsBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/v2.1/team/by-summoner/{1}", GetRegion(region), summonerId);

            return await SendRequest<List<Team>>(url);
        }
    }
}
