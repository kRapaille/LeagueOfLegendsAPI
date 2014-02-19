using System;
using System.Threading.Tasks;

namespace PortableLeagueApi.Core.Interfaces
{
    public interface IHttpRequestService
    {
        Task<IHttpResponseMessage> SendRequest(Uri uri);
    }
}