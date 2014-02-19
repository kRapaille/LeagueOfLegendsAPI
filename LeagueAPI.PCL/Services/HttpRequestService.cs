using System;
using System.Net.Http;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Models;

namespace PortableLeagueAPI.Services
{
    public class HttpRequestService : IHttpRequestService
    {
        public async Task<IHttpResponseMessage> SendRequestAsync(Uri uri)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                var httpResponseMessage = await httpClient.SendAsync(request);

                return new HttpResponseMessageWrapper
                {
                    Content = new HttpContentWrapper
                    {
                        ReadAsStringAsync = httpResponseMessage.Content.ReadAsStringAsync
                    },
                    IsSuccessStatusCode = httpResponseMessage.IsSuccessStatusCode,
                    StatusCode = httpResponseMessage.StatusCode
                };
            }
        }
    }
}
