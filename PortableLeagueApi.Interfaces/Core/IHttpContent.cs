using System;
using System.Threading.Tasks;

namespace PortableLeagueApi.Interfaces.Core
{
    public interface IHttpContent
    {
        Func<Task<string>> ReadAsStringAsync { get; set; }
    }
}