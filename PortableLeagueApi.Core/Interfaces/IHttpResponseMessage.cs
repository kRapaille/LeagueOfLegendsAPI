using System.Net;

namespace PortableLeagueApi.Core.Interfaces
{
    public interface IHttpResponseMessage
    {
        bool IsSuccessStatusCode { get; }
        IHttpContent Content { get; }

        HttpStatusCode StatusCode { get; }
    }
}