using System;
using System.Threading.Tasks;

namespace PortableLeagueApi.Core.Interfaces
{
    public interface IHttpRequestService
    {
        Task<IHttpResponseMessage> SendRequest<T>(Uri uri) where T : class;
    }
}