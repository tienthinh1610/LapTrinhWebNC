using System.Text.Json;
<<<<<<< HEAD

namespace SportsStore.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null
                ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
=======
namespace SportsStore.Infrastructure
{
  public static class SessionExtensions
  {
    public static void SetJson(this ISession session, string key, object value)
    {
      session.SetString(key, JsonSerializer.Serialize(value));
    }
    public static T? GetJson<T>(this ISession session, string key)
    {
      var sessionData = session.GetString(key);
      return sessionData == null
      ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
    }
  }
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
}