using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LeagueAPI.PCL.Helpers;
using LeagueAPI.PCL.Interfaces;
using LeagueAPI.PCL.Models.Constants;
using LeagueAPI.PCL.Models.Enums;
using LeagueAPI.PCL.Models.Exceptions;
using Newtonsoft.Json;

namespace LeagueAPI.PCL.Services
{
    public abstract class BaseService
    {
        private static readonly Uri BaseUri = new Uri("http://prod.api.pvp.net/api/");
        
        internal static IHttpRequestService HttpRequestService { private get; set; }
        internal static string Key { private get; set; }
        internal static RegionEnum? DefaultRegion { private get; set; }

        protected VersionEnum[] CompatibleVersions;

        protected async Task<T> GetResponse<T>(string relativeUrl) where T : class
        {
            return await GetResponse<T>(new Uri(relativeUrl, UriKind.Relative));
        }

        protected async Task<T> GetResponse<T>(Uri relativeUri) where T : class
        {
            var uriBuilder = new UriBuilder(new Uri(BaseUri, relativeUri));

            var keyParameter = string.Format("api_key={0}", Key);
            uriBuilder.AddQueryParameter(keyParameter);

            var response = await HttpRequestService.SendRequest<T>(uriBuilder.Uri);

            T result;

            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<T>(content);
            }
            else
            {
                Debug.WriteLine(uriBuilder.Uri.ToString());

                var apiRequestError = JsonConvert.DeserializeObject<APIRequestError>(content);
                throw new APIRequestException(apiRequestError, uriBuilder.Uri.ToString());
            }

            return result;
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
