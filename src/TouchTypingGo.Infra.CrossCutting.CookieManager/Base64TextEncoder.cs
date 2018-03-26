//Reference: https://www.c-sharpcorner.com/article/cookie-manager-wrapper-in-asp-net-core/

using System;
using System.Text;

namespace TouchTypingGo.Infra.CrossCutting.CookieManager
{
    internal static class Base64TextEncoder
    {
        public static string Decode(string text)
        {
            var data = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(data);
        }


        public static string Encode(string data)
        {
            var bytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(bytes);
        }

        public static bool TryDecode(string encodedText, out string plainText)
        {
            plainText = string.Empty;
            try
            {
                plainText = Decode(encodedText);
                return true;
            }
            catch (Exception)
            {
                // ignored
            }

            return false;
        }

    }
}
