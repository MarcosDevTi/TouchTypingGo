//Reference: https://www.c-sharpcorner.com/article/cookie-manager-wrapper-in-asp-net-core/
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;

namespace TouchTypingGo.Infra.CrossCutting.CookieManager
{
    public class DefaultCookieManager : ICookieManager
    {
        private readonly ICookie _cookie;

        public DefaultCookieManager(ICookie cookie)
        {
            _cookie = cookie;
        }


        public bool Contains(string key)
        {
            return _cookie.Contains(key);
        }

        public T GetOrSet<T>(string key, Func<T> acquirer, int? expireTime = default(int?))
        {
            if (_cookie.Contains(key))
            {
                return GetExisting<T>(key);
            }
            var value = acquirer();
            this.Set(key, value, expireTime);

            return value;
        }

        private T GetExisting<T>(string key)
        {
            var value = _cookie.Get(key);

            return string.IsNullOrEmpty(value) ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

        public void Remove(string key)
        {
            _cookie.Remove(key);
        }

        public void Set(string key, object value, int? expireTime = default(int?))
        {
            _cookie.Set(key, JsonConvert.SerializeObject(value), expireTime);
        }

        public T Get<T>(string key)
        {
            return GetExisting<T>(key);
        }

        public void Set(string key, object value, CookieOptions option)
        {
            _cookie.Set(key, JsonConvert.SerializeObject(value), option);
        }

        public T GetOrSet<T>(string key, Func<T> acquirer, CookieOptions option)
        {
            if (_cookie.Contains(key))
            {
                return GetExisting<T>(key);
            }
            var value = acquirer();
            this.Set(key, value, option);

            return value;
        }
    }
}
