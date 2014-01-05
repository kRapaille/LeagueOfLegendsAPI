using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PortableLeagueAPI.Interfaces
{
    public interface IHttpRequestService
    {
        Task<HttpResponseMessage> SendRequest<T>(Uri uri) where T : class;
    }
}