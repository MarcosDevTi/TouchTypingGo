using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.Services;
using TouchTypingGo.Domain.Core;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Commands.Course;
using TouchTypingGo.Domain.Course.Commands.Keyboard;
using TouchTypingGo.Domain.Course.Commands.LeconPresentation;
using TouchTypingGo.Domain.Course.Commands.LeconResult;
using TouchTypingGo.Domain.Course.Commands.Student;
using TouchTypingGo.Domain.Course.Commands.Teacher;
using TouchTypingGo.Domain.Course.Events;
using TouchTypingGo.Domain.Course.Events.EventHandlers;
using TouchTypingGo.Domain.Course.Events.Keyboard;
using TouchTypingGo.Domain.Course.Events.LeconPresentation;
using TouchTypingGo.Domain.Course.Events.LeconResult;
using TouchTypingGo.Domain.Course.Events.Student;
using TouchTypingGo.Domain.Course.Events.Teacher;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Domain.Interfaces;
using TouchTypingGo.Infra.CrossCutting.Bus;
using TouchTypingGo.Infra.CrossCutting.Identity.Models;
using TouchTypingGo.Infra.CrossCutting.Identity.Services;
using TouchTypingGo.Infra.Data.Context;
using TouchTypingGo.Infra.Data.Repository;
using TouchTypingGo.Infra.Data.UoW;

namespace TouchTypingGo.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            AutoMapperConfig.Configure();

            //Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(
                sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            //AppService
            services.AddScoped<ICourseAppService, CourseAppService>();
            services.AddScoped<ITeacherAppService, TeacherAppService>();
            services.AddScoped<ILeconPresentationAppService, LeconPresentationAppService>();
            services.AddScoped<ILeconResultAppService, LeconResultAppService>();
            services.AddScoped<IStudentAppService, StudentAppService>();
            services.AddScoped<IKeyboardAppService, KeyboardAppService>();

            //Domain - Commands
            //Course
            services.AddScoped<IHandler<CourseAddCommand>, CourseCommandHandler>();
            services.AddScoped<IHandler<CourseUpdateCommand>, CourseCommandHandler>();
            services.AddScoped<IHandler<CourseDeleteCommand>, CourseCommandHandler>();
           

            //Teacher
            services.AddScoped<IHandler<TeacherAddCommand>, TeacherCommandHandler>();
            services.AddScoped<IHandler<TeacherDeleteCommand>, TeacherCommandHandler>();

            //LeconPresentation
            services.AddScoped<IHandler<LeconPresentationAddCommand>, LeconPresentationCommandHandler>();
            services.AddScoped<IHandler<LeconPresentationDeleteCommand>, LeconPresentationCommandHandler>();

            //LeconResult
            services.AddScoped<IHandler<AddLeconResultCommand>, LeconResultCommandHandler>();
            services.AddScoped<IHandler<DeleteLeconResultCommand>, LeconResultCommandHandler>();

            //Student
            services.AddScoped<IHandler<AddStudentCommand>, StudentCommandHandler>();
            services.AddScoped<IHandler<DeleteStudentCommand>, StudentCommandHandler>();

            //Keyboard
            services.AddScoped<IHandler<AddKeyboardCommand>, KeyboardCommandHandler>();
            services.AddScoped<IHandler<DeleteKeyboardCommand>, KeyboardCommandHandler>();

            //Domain - Events
            services.AddScoped<IDomainNotificationHandler<DomainDotification>, DomainNotificationHandler>();

            //Events Courses
            services.AddScoped<IHandler<CourseAddEvent>, CourseEventHandler>();
            services.AddScoped<IHandler<CourseUpdateEvent>, CourseEventHandler>();
            services.AddScoped<IHandler<CourseDeleteEvent>, CourseEventHandler>();

            //Events Teacher
            services.AddScoped<IHandler<TeacherAddEvent>, TeacherEventHandler>();
            services.AddScoped<IHandler<TeacherDeleteEvent>, TeacherEventHandler>();

            //Lecon Presentation
            services.AddScoped<IHandler<LeconPresentationAddEvent>, LeconPresentationEventHandler>();
            services.AddScoped<IHandler<LeconPresentationDeleteEvent>, LeconPresentationEventHandler>();

            //Lesson Result
            services.AddScoped<IHandler<LeconResultAddEvent>, LeconResultEventHandler>();
            services.AddScoped<IHandler<LeconResultDeleteEvent>, LeconResultEventHandler>();

            //Student
            services.AddScoped<IHandler<AddStudentEvent>, StudentEventHandler>();
            services.AddScoped<IHandler<DeleteStudentEvent>, StudentEventHandler>();

            //Keyboard
            services.AddScoped<IHandler<AddKeyboardEvent>, KeyboardEventHandler>();
            services.AddScoped<IHandler<DeleteKeyboardEvent>, KeyboardEventHandler>();

            //Infra - Data
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<ILeconPresentationRepository, LeconPresentationRepository>();
            services.AddScoped<ILeconResultRepository, LeconResultRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IKeyboardRepository, KeyboardRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<TouchTypingGoContext>();

            //Infra - Bus
            services.AddScoped<IBus, InMemoryBus>();

            //Identity
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, User>();
        }
    }
}
