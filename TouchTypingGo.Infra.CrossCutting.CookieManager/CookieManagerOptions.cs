//Reference: https://www.c-sharpcorner.com/article/cookie-manager-wrapper-in-asp-net-core/
namespace TouchTypingGo.Infra.CrossCutting.CookieManager
{
    public class CookieManagerOptions
    {
        public bool AllowEncryption { get; set; } = true;
        public int DefaultExpireTimeInDays { get; set; } = 1;
        public int? ChunkSize { get; set; } = 4050;
        public bool ThrowForPartialCookies { get; set; } = true;
    }
}
