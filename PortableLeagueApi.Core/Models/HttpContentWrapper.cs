using System;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Interfaces;

namespace PortableLeagueApi.Core.Models
{
    public class HttpContentWrapper : IHttpContent
    {
        public Func<Task<string>> ReadAsStringAsync { get; set; }
    }
}
