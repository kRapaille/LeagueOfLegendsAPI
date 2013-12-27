using System;
using System.Linq;
using System.Threading.Tasks;
using LeagueAPI.PCL.Helpers;
using LeagueAPI.PCL.Interfaces;
using LeagueAPI.PCL.Models.Constants;
using LeagueAPI.PCL.Models.Enums;

namespace LeagueAPI.PCL.Services
{
    public abstract class BaseService
    {
        private static readonly Uri BaseUri = new Uri("http://prod.api.pvp.net/api/");
        
        internal static IHttpRequestService HttpRequestService;
        internal static string Key;
        internal static RegionEnum? DefaultRegion;

        protected VersionEnum[] CompatibleVersions;

        protected async Task<T> SendRequest<T>(string relativeUrl) where T : class
        {
            return await SendRequest<T>(new Uri(relativeUrl, UriKind.Relative));
        }

        protected async Task<T> SendRequest<T>(Uri relativeUri) where T : class
        {
            var uriBuilder = new UriBuilder(new Uri(BaseUri, relativeUri));

            var keyParameter = string.Format("api_key={0}", Key);
            uriBuilder.AddQueryParameter(keyParameter);

            return await HttpRequestService.SendRequest<T>(uriBuilder.Uri);
        }
        
        protected string GetRegion(RegionEnum? region)
        {
            region = region.HasValue ? region : DefaultRegion;

            if (region == null)
                throw new ArgumentException("There's no default region");

            return region.ToString().ToLower();
        }

        protected VersionEnum GetVersion(VersionEnum? version)
        {
            if (!version.HasValue)
                version = CompatibleVersions.Last();

            if (!CompatibleVersions.Contains(version.Value))
                throw new ArgumentException("Version not supported");

            return version.Value;
        }

        protected string GetVersionAsString(VersionEnum? version)
        {
            var versionValue = GetVersion(version);

            return VersionConsts.Versions[versionValue];
        }
    }
}
