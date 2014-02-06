using System;
using System.Threading.Tasks;

namespace PortableLeagueApi.Core.Interfaces
{
    public interface IHttpContent
    {
        Func<Task<string>> ReadAsStringAsync { get; set; }
    }
}