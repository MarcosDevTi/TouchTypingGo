using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.Services;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Events;
using TouchTypingGo.Domain.Course.Events.EventHandlers;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.CrossCutting.Bus;
using TouchTypingGo.Infra.Data.Context;
using TouchTypingGo.Infra.Data.Repository;
using TouchTypingGo.Infra.Data.UoW;

namespace TouchTypingGo.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(
                sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<ICourseAppService, CourseAppService>();

            //Domain - Commands
            services.AddScoped<IHandler<CourseAddCommand>, CourseCommandHandler>();
            services.AddScoped<IHandler<CourseUpdateCommand>, CourseCommandHandler>();
            services.AddScoped<IHandler<CourseDeleteCommand>, CourseCommandHandler>();

            //Domain - Events
            services.AddScoped<IDomainNotificationHandler<DomainDotification>, DomainNotificationHandler>();
            services.AddScoped<IHandler<CourseAddEvent>, CourseEventHandler>();
            services.AddScoped<IHandler<CourseUpdateEvent>, CourseEventHandler>();
            services.AddScoped<IHandler<CourseDeleteEvent>, CourseEventHandler>();

            //Infra - Data
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<TouchTypingGoContext>();

            //Infra - Bus
            services.AddScoped<IBus, InMemoryBus>();
        }
    }
}
