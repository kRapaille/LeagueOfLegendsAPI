using System.Collections.Generic;
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
            : base(config, VersionEnum.V2Rev3, "league")
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

        public async Task<IEnumerable<ILeagueItem>> RetrievesLeaguesEntryDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}/entry",
                summonerId);

            return await GetResponseAsync<IEnumerable<LeagueItemDto>, IEnumerable<ILeagueItem>>(region, url);
        }

        public async Task<IEnumerable<ILeague>> RetrievesLeaguesDataForSummonerAsync(
            long summonerId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-summoner/{0}",
                summonerId);

            return await GetResponseAsync<IEnumerable<LeagueDto>, IEnumerable<ILeague>>(region, url);
        }

        public async Task<IEnumerable<ILeagueItem>> RetrievesLeaguesEntryDataForTeamAsync(
            string teamId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-team/{0}/entry",
                teamId);

            return await GetResponseAsync<IEnumerable<LeagueItemDto>, IEnumerable<ILeagueItem>>(region, url);
        }

        public async Task<IEnumerable<ILeague>> RetrievesLeaguesDataForTeamAsync(
            string teamId,
            RegionEnum? region = null)
        {
            var url = string.Format("by-team/{0}",
                teamId);

            return await GetResponseAsync<IEnumerable<LeagueDto>, IEnumerable<ILeague>>(region, url);
        }
    }
}
