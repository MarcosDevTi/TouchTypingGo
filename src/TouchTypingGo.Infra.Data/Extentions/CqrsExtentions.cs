using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TouchTypingGo.Domain.Core.Cqrs;
using TouchTypingGo.Domain.Core.Cqrs.Command;
using TouchTypingGo.Domain.Core.Cqrs.Query;

namespace TouchTypingGo.Infra.Data.Extentions
{
    public static class CqrsExtentions
    {
        public static void AddCqrs(this IServiceCollection services)
        {
            var handlers = new[] { typeof(IQueryHandler<,>), typeof(ICommandHandler<>) };

            Assembly.GetExecutingAssembly().GetTypes()
                .ForEach(handle => handle.GetInterfaces()
                    .Where(g => g.IsConstructedGenericType)
                    .Where(g => handlers.Contains(g.GetGenericTypeDefinition()))
                    .ForEach(@interface => services.AddScoped(@interface, handle)));

            services.AddScoped<IProcessor, Processor>();
        }

        private static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            foreach (var item in list)
                action(item);
        }
    }
}
