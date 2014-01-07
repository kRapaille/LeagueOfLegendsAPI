using PortableLeagueAPI.Interfaces;
using PortableLeagueAPI.Services;

namespace PortableLeagueAPI.Models.IoC
{
    public class LeagueResolver : IResolver
    {
        private static IHttpRequestService _httpRequestService;

        public static IHttpRequestService HttpRequestService
        {
            get { return _httpRequestService ?? (_httpRequestService = new HttpRequestService()); }
        }

        public T Resolve<T>() where T : class
        {
            if(typeof(T) == typeof(IHttpRequestService))
                return (T)HttpRequestService;

            return null;
        }
    }
}