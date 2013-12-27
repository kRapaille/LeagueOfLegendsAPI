using System;

namespace LeagueAPI.PCL.Helpers
{
    internal static class UriExtensions
    {
        internal static void AddQueryParameter(this UriBuilder uriBuilder, string parameter)
        {
            if (uriBuilder.Query != null && uriBuilder.Query.Length > 1)
                uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + parameter;
            else
                uriBuilder.Query = parameter;
        }
    }
}
