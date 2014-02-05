using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PortableLeagueApi.Core.Interfaces
{
    public interface IHttpRequestService
    {
        Task<HttpResponseMessage> SendRequest<T>(Uri uri) where T : class;
    }
}