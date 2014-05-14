using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.League.Models.DTO;

namespace PortableLeagueApi.League.Services
{
    public class LeagueService : BaseService, ILeagueService
    {
        public LeagueService(
            ILeagueApiConfiguration config)
            : base(config, VersionEnum.V2Rev4, "league")
        {
            Models.League.CreateMap(AutoMapperService);

#if DEBUG
            AutoMapperService.AssertConfigurationIsValid();
#endif
        }

        public async Task<ILeague> RetrievesChallengerTierLeaguesAsync(
            LeagueTypeEnum leagueType,
            RegionEnum? region = null)
        {
            var url = string.Format("challenger?type={0}", LeagueTypeConsts.LeagueTypes[leagueType]);

            return await GetResponseAsync<LeagueDto, ILeague>(region, url);
        }

        public async Task<IEnumerable<ILeague>> RetrievesLeaguesEntryDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await RetrievesLeaguesEntryDataForSummonerAsync(new[] { summonerId }, region);

            return result.Values.FirstOrDefault();
        }

        public async Task<IDictionary<string, IEnumerable<ILeague>>> RetrievesLeaguesEntryDataForSummonerAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/entry",
                string.Join(",", summonerIds));

            return await GetResponseAsync<IDictionary<string, IEnumerable<LeagueDto>>, IDictionary<string, IEnumerable<ILeague>>>(region, url);
        }

        public async Task<IEnumerable<ILeague>> RetrievesLeaguesDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var result = await RetrievesLeaguesDataForSummonerAsync(new[] { summonerId }, region);

            return result.Values.FirstOrDefault();
        }

        public async Task<IDictionary<string, IEnumerable<ILeague>>> RetrievesLeaguesDataForSummonerAsync(
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                string.Join(",", summonerIds));

            return await GetResponseAsync<IDictionary<string, IEnumerable<LeagueDto>>, IDictionary<string, IEnumerable<ILeague>>>(region, url);
        }

        public async Task<IEnumerable<ILeague>> RetrievesLeaguesEntryDataForTeamAsync(
            string teamId,
            RegionEnum? region = null)
        {
            var result = await RetrievesLeaguesEntryDataForTeamAsync(new[] { teamId }, region);

            return result.Values.FirstOrDefault();
        }

        public async Task<IDictionary<string, IEnumerable<ILeague>>> RetrievesLeaguesEntryDataForTeamAsync(
            IEnumerable<string> teamIds,
            RegionEnum? region = null)
        {
            var url = string.Format("by-team/{0}/entry",
                string.Join(",", teamIds));

            return await GetResponseAsync<IDictionary<string, IEnumerable<LeagueDto>>, IDictionary<string, IEnumerable<ILeague>>>(region, url);
        }

        public async Task<IEnumerable<ILeague>> RetrievesLeaguesDataForTeamAsync(
            string teamId,
            RegionEnum? region = null)
        {
            var result = await RetrievesLeaguesDataForTeamAsync(new[] { teamId }, region);

            return result.Values.FirstOrDefault();
        }

        public async Task<IDictionary<string, IEnumerable<ILeague>>> RetrievesLeaguesDataForTeamAsync(
            IEnumerable<string> teamIds,
            RegionEnum? region = null)
        {
            var url = string.Format("by-team/{0}",
                string.Join(",", teamIds));

            return await GetResponseAsync<IDictionary<string, IEnumerable<LeagueDto>>, IDictionary<string, IEnumerable<ILeague>>>(region, url);
        }
    }
}
