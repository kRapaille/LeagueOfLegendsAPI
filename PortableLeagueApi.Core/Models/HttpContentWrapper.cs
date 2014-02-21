using System;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Core.Models
{
    public class HttpContentWrapper : IHttpContent
    {
        public Func<Task<string>> ReadAsStringAsync { get; set; }
    }
}
