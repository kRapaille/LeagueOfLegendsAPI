using System;
using System.Net.Http;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueAPI.Services
{
    public class HttpRequestService : IHttpRequestService
    {
        private readonly HttpMessageHandler _messageHandler;

        public HttpRequestService(HttpMessageHandler messageHandler = null)
        {
            _messageHandler = messageHandler ?? new HttpClientHandler();
        }

        public async Task<IHttpResponseMessage> SendRequestAsync(Uri uri)
        {
            using (var httpClient = new HttpClient(_messageHandler, false))
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
