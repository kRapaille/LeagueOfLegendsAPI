using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueAPI.Models;
using PortableLeagueAPI.Models.Constants;
using PortableLeagueAPI.Models.Enums;

namespace PortableLeagueAPI.Services
{
    public class LeagueService : BaseService
    {
        private LeagueService()
        {
            CompatibleVersions = new[]
            {
                VersionEnum.V2Rev1,
                VersionEnum.V2Rev2
            };
        }

        private static LeagueService _instance;

        internal static LeagueService Instance
        {
            get { return _instance ?? (_instance = new LeagueService()); }
        }

        public async Task<Dictionary<string, League>> GetLeagueInfosBySummonerId(
            long summonerId,
            RegionEnum? region = null,
            VersionEnum? version = null)
        {
            var versionValue = GetVersion(version);

            var url = string.Format("{0}{1}/{2}/league/by-summoner/{3}", 
                versionValue == VersionEnum.V2Rev1 ? string.Empty : "lol/",
                GetRegion(region),
                VersionConsts.Versions[versionValue],
                summonerId);

            return await GetResponse<Dictionary<string, League>>(url);
        }
    }
}
