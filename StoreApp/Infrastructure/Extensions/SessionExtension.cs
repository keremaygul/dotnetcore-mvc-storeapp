using System.Text.Json;

namespace StoreApp.Infrastructure.Extensions
{
    public static class SessionExtension
    {
        // objeye bağlı çalışır
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        // aynısı aslında farkı generic olması verdiğin tipe göre çalışır
        public static void SetJson<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? GetJson<T>(this ISession session, string key)
        {
            var data = session.GetString(key);
            return data is null
                ? default(T)
                : JsonSerializer.Deserialize<T>(data);
        }
    }
}