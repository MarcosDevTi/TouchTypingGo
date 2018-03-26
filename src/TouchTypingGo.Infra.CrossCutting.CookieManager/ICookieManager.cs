//Reference: https://www.c-sharpcorner.com/article/cookie-manager-wrapper-in-asp-net-core/
using Microsoft.AspNetCore.Http;
using System;

namespace TouchTypingGo.Infra.CrossCutting.CookieManager
{
    public interface ICookieManager
    {
        T Get<T>(string key);
        T GetOrSet<T>(string key, Func<T> acquirer, int? expireTime = null);
        T GetOrSet<T>(string key, Func<T> acquirer, CookieOptions option);
        void Set(string key, object value, int? expireTime = null);
        void Set(string key, object value, CookieOptions option);
        bool Contains(string key);
        void Remove(string key);
    }
}
