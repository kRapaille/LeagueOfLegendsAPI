using Newtonsoft.Json;

namespace PortableLeagueApi.Core.Models
{
    public class APIRequestError
    {
        [JsonProperty("status")]
        public APIRequestErrorStatus Status { get; set; }
    }

    public class APIRequestErrorStatus
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }
    }

}
