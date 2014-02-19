using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Interfaces;
using PortableLeagueApi.Core.Models;
using PortableLeagueAPI.Test.Responses;

namespace PortableLeagueAPI.Test
{
    class FakeHttpRequestService : IHttpRequestService
    {
        public async Task<IHttpResponseMessage> SendRequest(Uri uri)
        {
            string response = null;

            var pathAndQuery = uri.PathAndQuery.ToLower();

            var responsesInstances = new List<IResponses>
            {
                ChampionResponses.Instance,
                GameResponses.Instance,
                LeagueResponses.Instance,
                StatsResponses.Instance,
                SummonerResponses.Instance,
                TeamResponses.Instance
            };

            foreach (var responsesInstance in responsesInstances)
            {
                response = responsesInstance.GetResponse(pathAndQuery);

                if (response != null)
                    break;
            }

            await Task.Delay(0);

            return new HttpResponseMessageWrapper
            {
                Content = new HttpContentWrapper
                {
                    ReadAsStringAsync = () => ReadAsStringAsync(response)
                },
                IsSuccessStatusCode = true,
                StatusCode = HttpStatusCode.OK
            };
        }

        public async Task<string> ReadAsStringAsync(string response)
        {
            await Task.Delay(0);

            return response;
        }
    }
}
