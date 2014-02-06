using PortableLeagueApi.Core.Interfaces;

namespace PortableLeagueAPI.Test
{
    public class FakeResolver : IResolver
    {
        private static IHttpRequestService _httpRequestService;

        public static IHttpRequestService HttpRequestService
        {
            get { return _httpRequestService ?? (_httpRequestService = new FakeHttpRequestService()); }
        }

        public T Resolve<T>() where T : class
        {
            if (typeof(T) == typeof(IHttpRequestService))
                return (T)HttpRequestService;

            return null;
        }
    }
}
