using System;
using System.Threading.Tasks;

namespace LeagueAPI.PCL.Interfaces
{
    public interface IHttpRequestService
    {
        Task<T> SendRequest<T>(Uri uri) where T : class;
    }
}