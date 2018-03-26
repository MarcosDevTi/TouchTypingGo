//Reference: https://www.c-sharpcorner.com/article/cookie-manager-wrapper-in-asp-net-core/
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.CrossCutting.CookieManager
{
    public class HttpCookie : ICookie
    {
        private readonly HttpContext _httpContext;
        private readonly IDataProtector _dataProtector;
        private static readonly string Purpose = "CookieManager.Token.v1";
        private readonly CookieManagerOptions _cookieManagerOptions;
        private readonly ChunkingHttpCookie _chunkingHttpCookie;

        public HttpCookie(IHttpContextAccessor httpAccessor,
            IDataProtectionProvider dataProtectionProvider,
            IOptions<CookieManagerOptions> optionAccessor)
        {
            _httpContext = httpAccessor.HttpContext;
            _dataProtector = dataProtectionProvider.CreateProtector(Purpose);
            _cookieManagerOptions = optionAccessor.Value;
            _chunkingHttpCookie = new ChunkingHttpCookie(optionAccessor);
        }

        public ICollection<string> Keys
        {
            get
            {
                if (_httpContext == null)
                {
                    throw new ArgumentNullException(nameof(_httpContext));
                }

                return _httpContext.Request.Cookies.Keys;
            }
        }

        public bool Contains(string key)
        {
            if (_httpContext == null)
            {
                throw new ArgumentNullException(nameof(_httpContext));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            return _httpContext.Request.Cookies.ContainsKey(key);
        }

        public string Get(string key)
        {
            if (_httpContext == null)
            {
                throw new ArgumentNullException(nameof(_httpContext));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (!Contains(key)) return string.Empty;
            var encodedValue = _chunkingHttpCookie.GetRequestCookie(_httpContext, key);
            if (!Base64TextEncoder.TryDecode(encodedValue, out var protectedData)) return encodedValue;
            return _dataProtector.TryUnprotect(protectedData, out var unprotectedData) ? unprotectedData : encodedValue;
        }

        public void Remove(string key)
        {
            if (_httpContext == null)
            {
                throw new ArgumentNullException(nameof(_httpContext));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            _chunkingHttpCookie.RemoveCookie(_httpContext, key);
        }

        public void Set(string key, string value, int? expireTime)
        {
            if (_httpContext == null)
            {
                throw new ArgumentNullException(nameof(_httpContext));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Set(key, value, null, expireTime);
        }

        public void Set(string key, string value, CookieOptions option)
        {
            if (_httpContext == null)
            {
                throw new ArgumentNullException(nameof(_httpContext));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (option == null)
            {
                throw new ArgumentNullException(nameof(option));
            }

            Set(key, value, option, null);
        }

        private void Set(string key, string value, CookieOptions option, int? expireTime)
        {
            if (option == null)
            {
                option = new CookieOptions
                {
                    Expires = expireTime.HasValue
                        ? DateTime.Now.AddMinutes(expireTime.Value)
                        : DateTime.Now.AddDays(_cookieManagerOptions.DefaultExpireTimeInDays)
                };

            }

            if (_cookieManagerOptions.AllowEncryption)
            {
                var protecetedData = _dataProtector.Protect(value);
                var encodedValue = Base64TextEncoder.Encode(protecetedData);
                _chunkingHttpCookie.AppendResponseCookie(_httpContext, key, encodedValue, option);
            }
            else
            {
                _chunkingHttpCookie.AppendResponseCookie(_httpContext, key, value, option);
            }

        }
    }
}
