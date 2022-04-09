using System;
using Microsoft.AspNetCore.Http;

namespace BookstoreProject.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathandQuery(this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}
