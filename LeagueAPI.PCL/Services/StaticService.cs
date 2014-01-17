using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueAPI.Models.Enums;
using PortableLeagueAPI.Models.Static;

namespace PortableLeagueAPI.Services
{
    public class StaticService : BaseService
    {
        private static readonly Dictionary<RegionEnum, StaticAPIVersions> StaticAPIVersions = new Dictionary<RegionEnum, StaticAPIVersions>();
        private static StaticService _instance;

        internal static StaticService Instance
        {
            get { return _instance ?? (_instance = new StaticService()); }
        }
        
        private async Task<StaticAPIVersions> GetVersioningByRegion(
            RegionEnum? region = null)
        {
            var regionValue = GetRegion(region);

            if (!StaticAPIVersions.ContainsKey(regionValue))
            {
                var url = string.Format("http://ddragon.leagueoflegends.com/realms/{0}.json",
                    GetRegionAsString(region));

                var result = await GetResponse<StaticVersioningRoot>(new Uri(url));

                return result.StaticAPIVersions;
            }

            return StaticAPIVersions[regionValue];
        }

        public async Task<Dictionary<string, Item>> GetItems(
            RegionEnum? region = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/en_US/item.json",
                    lastVersions.Item);

            var result = await GetResponse<ItemRootObject>(new Uri(url));

            return result.data;
        }

        public async Task<Dictionary<string, RuneItem>> GetRunes(
            RegionEnum? region = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/en_US/rune.json",
                    lastVersions.Rune);

            var result = await GetResponse<RuneRootObject>(new Uri(url));

            return result.data;
        }

        public async Task<Dictionary<string, Mastery>> GetMasteries(
            RegionEnum? region = null)
        {
            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/en_US/mastery.json",
                    lastVersions.Mastery);

            var result = await GetResponse<MasteryRootobject>(new Uri(url));

            return result.data;
        }

        public async Task<Dictionary<string, Summoner>> GetSummoners(
            RegionEnum? region = null)
        {
            throw new NotImplementedException();

            var lastVersions = await GetVersioningByRegion(region);
            var url = string.Format("http://ddragon.leagueoflegends.com/cdn/{0}/data/en_US/summoner.json",
                    lastVersions.Mastery);

            var result = await GetResponse<SummonerRootobject>(new Uri(url));

            return result.data;
        }
    }
}
