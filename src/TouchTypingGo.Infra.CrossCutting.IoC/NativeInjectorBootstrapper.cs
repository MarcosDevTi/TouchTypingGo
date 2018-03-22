using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.Services;
using TouchTypingGo.Application.Services.Helper;
using TouchTypingGo.Domain.Core;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Commands.Course;
using TouchTypingGo.Domain.Course.Commands.Keyboard;
using TouchTypingGo.Domain.Course.Commands.LessonPresentation;
using TouchTypingGo.Domain.Course.Commands.LessonResult;
using TouchTypingGo.Domain.Course.Commands.Student;
using TouchTypingGo.Domain.Course.Commands.Teacher;
using TouchTypingGo.Domain.Course.Events;
using TouchTypingGo.Domain.Course.Events.Course;
using TouchTypingGo.Domain.Course.Events.EventHandlers;
using TouchTypingGo.Domain.Course.Events.Keyboard;
using TouchTypingGo.Domain.Course.Events.LessonPresentation;
using TouchTypingGo.Domain.Course.Events.LessonResult;
using TouchTypingGo.Domain.Course.Events.Student;
using TouchTypingGo.Domain.Course.Events.Teacher;
using TouchTypingGo.Domain.Course.Repository;
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
            services.AddScoped<IlessonPresentationAppService, LessonPresentationAppService>();
            services.AddScoped<IlessonResultAppService, lessonResultAppService>();
            services.AddScoped<IStudentAppService, StudentAppService>();
            services.AddScoped<IKeyboardAppService, KeyboardAppService>();
            services.AddScoped<ILessonListAppService, LessonListAppService>();

            services.AddScoped<IHelperService, HelperService>();

            //Domain - Commands
            //Course
            services.AddScoped<IHandler<CourseAddCommand>, CourseCommandHandler>();
            services.AddScoped<IHandler<CourseUpdateCommand>, CourseCommandHandler>();
            services.AddScoped<IHandler<CourseDeleteCommand>, CourseCommandHandler>();
           

            //Teacher
            services.AddScoped<IHandler<TeacherAddCommand>, TeacherCommandHandler>();
            services.AddScoped<IHandler<TeacherDeleteCommand>, TeacherCommandHandler>();

            //LessonPresentation
            services.AddScoped<IHandler<LessonPresentationAddCommand>, LessonPresentationCommandHandler>();
            services.AddScoped<IHandler<LessonPresentationDeleteCommand>, LessonPresentationCommandHandler>();

            //LessonResult
            services.AddScoped<IHandler<AddLessonResultCommand>, LessonResultCommandHandler>();
            services.AddScoped<IHandler<DeleteLessonResultCommand>, LessonResultCommandHandler>();

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

            //lesson Presentation
            services.AddScoped<IHandler<LessonPresentationAddEvent>, lessonPresentationEventHandler>();
            services.AddScoped<IHandler<LessonPresentationDeleteEvent>, lessonPresentationEventHandler>();

            //Lesson Result
            services.AddScoped<IHandler<LessonResultAddEvent>, lessonResultEventHandler>();
            services.AddScoped<IHandler<LessonResultDeleteEvent>, lessonResultEventHandler>();

            //Student
            services.AddScoped<IHandler<AddStudentEvent>, StudentEventHandler>();
            services.AddScoped<IHandler<DeleteStudentEvent>, StudentEventHandler>();

            //Keyboard
            services.AddScoped<IHandler<AddKeyboardEvent>, KeyboardEventHandler>();
            services.AddScoped<IHandler<DeleteKeyboardEvent>, KeyboardEventHandler>();

            //Infra - Data
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<ILessonPresentationRepository, lessonPresentationRepository>();
            services.AddScoped<ILessonResultRepository, lessonResultRepository>();
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
