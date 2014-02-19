using System;
using System.Threading.Tasks;

namespace PortableLeagueApi.Core.Interfaces
{
    public interface IHttpRequestService
    {
        Task<IHttpResponseMessage> SendRequestAsync(Uri uri);
    }
}