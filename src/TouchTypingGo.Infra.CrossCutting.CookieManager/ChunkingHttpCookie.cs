//Reference: https://www.c-sharpcorner.com/article/cookie-manager-wrapper-in-asp-net-core/
// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using System;
using System.Globalization;

namespace TouchTypingGo.Infra.CrossCutting.CookieManager
{
    internal class ChunkingHttpCookie
    {
        private readonly CookieManagerOptions _cookieManagerOptions;

        private const string ChunkKeySuffix = "C";
        private const string ChunkCountPrefix = "chunks-";

        public ChunkingHttpCookie(IOptions<CookieManagerOptions> optionAccessor)
        {
            _cookieManagerOptions = optionAccessor.Value;
        }

        private int ParseChunksCount(string value)
        {
            if (value == null || !value.StartsWith(ChunkCountPrefix, StringComparison.Ordinal)) return 0;
            var chunksCountString = value.Substring(ChunkCountPrefix.Length);
            return int.TryParse(chunksCountString, NumberStyles.None, CultureInfo.InvariantCulture, out var chunksCount) ? chunksCount : 0;
        }

        public string GetRequestCookie(HttpContext context, string key)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var requestCookies = context.Request.Cookies;
            var value = requestCookies[key];
            var chunksCount = ParseChunksCount(value);
            if (chunksCount <= 0) return value;
            var chunks = new string[chunksCount];
            for (var chunkId = 1; chunkId <= chunksCount; chunkId++)
            {
                var chunk = requestCookies[key + ChunkKeySuffix + chunkId.ToString(CultureInfo.InvariantCulture)];
                if (string.IsNullOrEmpty(chunk))
                {
                    if (!_cookieManagerOptions.ThrowForPartialCookies) return value;
                    var totalSize = 0;
                    for (var i = 0; i < chunkId - 1; i++)
                    {
                        totalSize += chunks[i].Length;
                    }
                    throw new FormatException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            "The chunked cookie is incomplete. Only {0} of the expected {1} chunks were found, totaling {2} characters. A client size limit may have been exceeded.",
                            chunkId - 1,
                            chunksCount,
                            totalSize));
                }

                chunks[chunkId - 1] = chunk;
            }

            return string.Join(string.Empty, chunks);
        }


        public void AppendResponseCookie(HttpContext context, string key, string value, CookieOptions options)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var template = new SetCookieHeaderValue(key)
            {
                Domain = options.Domain,
                Expires = options.Expires,
                HttpOnly = options.HttpOnly,
                Path = options.Path,
                Secure = options.Secure,
            };

            var templateLength = template.ToString().Length;

            value = value ?? string.Empty;

            var responseCookies = context.Response.Cookies;
            if (!_cookieManagerOptions.ChunkSize.HasValue || _cookieManagerOptions.ChunkSize.Value > templateLength + value.Length)
            {
                responseCookies.Append(key, value, options);
            }
            else if (_cookieManagerOptions.ChunkSize.Value < templateLength + 10)
            {
                throw new InvalidOperationException("The cookie key and options are larger than ChunksSize, leaving no room for data.");
            }
            else
            {
                var dataSizePerCookie = _cookieManagerOptions.ChunkSize.Value - templateLength - 3;
                var cookieChunkCount = (int)Math.Ceiling(value.Length * 1.0 / dataSizePerCookie);

                responseCookies.Append(key, ChunkCountPrefix + cookieChunkCount.ToString(CultureInfo.InvariantCulture), options);

                var offset = 0;
                for (var chunkId = 1; chunkId <= cookieChunkCount; chunkId++)
                {
                    var remainingLength = value.Length - offset;
                    var length = Math.Min(dataSizePerCookie, remainingLength);
                    var segment = value.Substring(offset, length);
                    offset += length;

                    responseCookies.Append(key + ChunkKeySuffix + chunkId.ToString(CultureInfo.InvariantCulture), segment, options);
                }
            }
        }

        public void RemoveCookie(HttpContext context, string key)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var value = context.Request.Cookies[key];
            var chunksCount = ParseChunksCount(value);
            if (chunksCount > 0)
            {
                for (var chunkId = 1; chunkId <= chunksCount; chunkId++)
                {
                    context.Response.Cookies.Delete(key + ChunkKeySuffix + chunkId.ToString(CultureInfo.InvariantCulture));
                }
            }
            else
                context.Response.Cookies.Delete(key);
        }
    }
}
