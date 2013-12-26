using System;
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

        private static readonly Uri BaseUri = new Uri("https://prod.api.pvp.net/api/");
        private readonly RegionEnum _region;

        public LeagueAPIService(string key, RegionEnum region)
        {
            _key = key;
            _region = region;
        }

        private async Task<T> SendRequest<T>(string relativeUrl) where T : class
        {
            return await SendRequest<T>(new Uri(relativeUrl, UriKind.Relative));
        }

        private async Task<T> SendRequest<T>(Uri relativeUri) where T : class
        {
            var uriBuilder = new UriBuilder(new Uri(BaseUri, relativeUri));

            var keyParameter = string.Format("api_key={0}", _key);
            if (uriBuilder.Query != null && uriBuilder.Query.Length > 1)
                uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + keyParameter;
            else
                uriBuilder.Query = keyParameter;

            var uri = uriBuilder.Uri;

            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            var response = await httpClient.SendAsync(request);

            T result;

            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<T>(content);
            }
            else
            {
                Debug.WriteLine(uri.ToString());

                var apiRequestError = JsonConvert.DeserializeObject<APIRequestError>(content);
                throw new APIRequestException(apiRequestError, uri.ToString());
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

            var championsRoot = await SendRequest<ChampionsRoot>(url);

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

        public async Task<Dictionary<string, League>> GetLeagueInfosBySummonerId(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("{0}/v2.1/league/by-summoner/{1}", GetRegion(region), summonerId);

            return await SendRequest<Dictionary<string, League>>(url);
        }

        public async Task<IEnumerable<PlayerStatSummary>> GetPlayerStatsSummariesBySummonerId(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/stats/by-summoner/{1}/summary", GetRegion(region), summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            var playerStatSummaryRoot = await SendRequest<PlayerStatSummaryRoot>(url);

            return playerStatSummaryRoot.PlayerStatSummaries.AsEnumerable();
        }

        public async Task<RankedStats> GetRankedStatsSummariesBySummonerId(
            long summonerId,
            SeasonEnum? season = null,
            RegionEnum? region = null)
        {
            var url = string.Format("lol/{0}/v1.1/stats/by-summoner/{1}/ranked", GetRegion(region), summonerId);

            if (season.HasValue)
                url += string.Concat("?season=", season.ToString().ToUpper());

            var rankedStatsRoot = await SendRequest<RankedStats>(url);

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
