//Reference: https://www.c-sharpcorner.com/article/cookie-manager-wrapper-in-asp-net-core/
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace TouchTypingGo.Infra.CrossCutting.CookieManager
{
    public static class ConfigureServiceExtension
    {
        public static IServiceCollection AddCookieManager(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.TryAdd(ServiceDescriptor.Transient<ICookie, HttpCookie>());
            services.TryAdd(ServiceDescriptor.Transient<ICookieManager, DefaultCookieManager>());

            return services;
        }

        public static IServiceCollection AddCookieManager(this IServiceCollection services, Action<CookieManagerOptions> options)
        {
            AddCookieManager(services);
            services.Configure(options);

            return services;
        }
    }
}
