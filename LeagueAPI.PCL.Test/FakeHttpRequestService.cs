using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueAPI.Test.Responses;
using PortableLeagueAPI.Test.Responses.Champion;
using PortableLeagueAPI.Test.Responses.Game;
using PortableLeagueAPI.Test.Responses.League;
using PortableLeagueAPI.Test.Responses.Static;
using PortableLeagueAPI.Test.Responses.Stats;
using PortableLeagueAPI.Test.Responses.Summoner;
using PortableLeagueAPI.Test.Responses.Team;

namespace PortableLeagueAPI.Test
{
    class FakeHttpRequestService : IHttpRequestService
    {
        public async Task<IHttpResponseMessage> SendRequestAsync(Uri uri)
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
                TeamResponses.Instance,
                StaticResponses.Instance
            };

            foreach (var responsesInstance in responsesInstances)
            {
                response = await responsesInstance.GetResponse(pathAndQuery);

                if (response != null)
                    break;
            }
            
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
