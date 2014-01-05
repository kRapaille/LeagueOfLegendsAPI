using System;

namespace PortableLeagueAPI.Models.Exceptions
{
    public class APIRequestException : Exception
    {
        public APIRequestError APIRequestError { get; set; }
        public string Url { get; set; }

        public APIRequestException(APIRequestError apiRequestError, string url)
            : base(apiRequestError.Status.Message)
        {
            if (apiRequestError == null || apiRequestError.Status == null)
                throw new ArgumentException();

            APIRequestError = apiRequestError;
            Url = url;
        }
    }
}
