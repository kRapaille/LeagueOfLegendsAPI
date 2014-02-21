using System;
using System.Threading.Tasks;

namespace PortableLeagueApi.Interfaces.Core
{
    public interface IHttpRequestService
    {
        Task<IHttpResponseMessage> SendRequestAsync(Uri uri);
    }
}