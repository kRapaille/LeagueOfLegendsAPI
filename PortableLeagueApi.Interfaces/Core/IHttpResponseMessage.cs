using System.Net;

namespace PortableLeagueApi.Interfaces.Core
{
    public interface IHttpResponseMessage
    {
        bool IsSuccessStatusCode { get; }
        IHttpContent Content { get; }
        HttpStatusCode StatusCode { get; }
    }
}