using System;

namespace PortableLeagueApi.Core.Models
{
    public class APIRequestException : Exception
    {
        public APIRequestErrorStatus APIRequestError { get; set; }
        public string Url { get; set; }

        public APIRequestException(APIRequestError apiRequestError, string url)
            : base(apiRequestError.Status.Message)
        {
            if (apiRequestError == null || apiRequestError.Status == null)
                throw new ArgumentException();

            APIRequestError = apiRequestError.Status;
            Url = url;
        }
    }
}
