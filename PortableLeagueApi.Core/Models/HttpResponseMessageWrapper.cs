using System.Net;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Core.Models
{
    public class HttpResponseMessageWrapper : IHttpResponseMessage
    {
        public bool IsSuccessStatusCode { get; set; }

        public IHttpContent Content { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
