using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Exceptions
{
    public class APIRequestError
    {
        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class Status
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }
    }

}
