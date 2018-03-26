//Reference: https://www.c-sharpcorner.com/article/cookie-manager-wrapper-in-asp-net-core/
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.CrossCutting.CookieManager
{
    public interface ICookie
    {
        ICollection<string> Keys { get; }
        string Get(string key);
        void Set(string key, string value, int? expireTime);
        void Set(string key, string value, CookieOptions option);
        bool Contains(string key);
        void Remove(string key);
    }
}
