using System.Net;
using PortableLeagueApi.Core.Interfaces;

namespace PortableLeagueApi.Core.Models
{
    public class HttpResponseMessageWrapper : IHttpResponseMessage
    {
        public bool IsSuccessStatusCode { get; set; }

        public IHttpContent Content { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
