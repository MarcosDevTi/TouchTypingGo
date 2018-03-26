//Reference: https://www.c-sharpcorner.com/article/cookie-manager-wrapper-in-asp-net-core/
using Microsoft.AspNetCore.DataProtection;
using System;

namespace TouchTypingGo.Infra.CrossCutting.CookieManager
{
    public static class DataProtectorExtension
    {
        public static bool TryUnprotect(this IDataProtector dataProtector, string protectedData, out string unProtectedData)
        {
            unProtectedData = string.Empty;
            try
            {
                unProtectedData = dataProtector.Unprotect(protectedData);
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
