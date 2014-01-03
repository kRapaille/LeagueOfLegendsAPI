using System;
using System.Net.Http;
using System.Threading.Tasks;
using LeagueAPI.PCL.Interfaces;

namespace LeagueAPI.PCL.Services
{
    public class HttpRequestService : IHttpRequestService
    {
        public async Task<HttpResponseMessage> SendRequest<T>(Uri uri) where T : class
        {
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                return await httpClient.SendAsync(request);   
            }
        }
    }
}
