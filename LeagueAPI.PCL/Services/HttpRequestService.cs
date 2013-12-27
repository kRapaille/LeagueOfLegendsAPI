using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using LeagueAPI.PCL.Interfaces;
using LeagueAPI.PCL.Models.Exceptions;
using Newtonsoft.Json;

namespace LeagueAPI.PCL.Services
{
    public class HttpRequestService : IHttpRequestService
    {
        public async Task<T> SendRequest<T>(Uri uri) where T : class
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            var response = await httpClient.SendAsync(request);

            T result;

            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<T>(content);
            }
            else
            {
                Debug.WriteLine(uri.ToString());

                var apiRequestError = JsonConvert.DeserializeObject<APIRequestError>(content);
                throw new APIRequestException(apiRequestError, uri.ToString());
            }

            return result;
        }
    }
}
