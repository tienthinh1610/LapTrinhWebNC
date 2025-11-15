namespace SportsStore.Infrastructure
{
<<<<<<< HEAD
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue
                ? $"{request.Path}{request.QueryString}"
                : request.Path.ToString();
    }
=======
  public static class UrlExtensions
  {
    public static string PathAndQuery(this HttpRequest request) =>
        request.QueryString.HasValue
            ? $"{request.Path}{request.QueryString}"
            : request.Path.ToString();
  }
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
}