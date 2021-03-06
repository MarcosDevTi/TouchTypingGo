﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Globalization;
using TouchTypingGo.Infra.CrossCutting.Bus;
using TouchTypingGo.Infra.CrossCutting.CookieManager;
using TouchTypingGo.Infra.CrossCutting.Filters;
using TouchTypingGo.Infra.CrossCutting.Identity.Data;
using TouchTypingGo.Infra.CrossCutting.Identity.Models;
using TouchTypingGo.Infra.CrossCutting.IoC;
using TouchTypingGo.Site.Validation;

namespace TouchTypingGo.Site
{
    public class Startup
    {
        private HostingEnvironment env;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath);
            Configuration = builder.Build();

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            var mvcBuilder = services.AddMvc(options =>
            {
                options.Filters.Add(new ServiceFilterAttribute(typeof(GlobalExceptionHandlingFilter)));
                options.Filters.Add(new ServiceFilterAttribute(typeof(GlobalActionLogger)));
            });

            RegisterLocalizations(services, mvcBuilder);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            RegisterServices(services);

            services.AddCookieManager(options =>
            {
                options.AllowEncryption = false;
                options.ThrowForPartialCookies = true;
                options.DefaultExpireTimeInDays = 30;
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("CanReadCourses", policy => policy.RequireClaim("Courses", "Read"));
                options.AddPolicy("CanWriteCourses", policy => policy.RequireClaim("Courses", "Write"));
                options.AddPolicy("Create", policy => policy.RequireClaim("Course", "Create"));
                options.AddPolicy("Create", policy => policy.RequireClaim("Lesson", "Create"));
            });
        }

        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env,
            IHttpContextAccessor accessor)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
                app.UseStatusCodePagesWithReExecute("/error/{0}");
            }

            app.UseStaticFiles();

            app.UseRequestLocalization();

            app.UseAuthentication();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            InMemoryBus.ContainerAcessor = () => accessor.HttpContext.RequestServices;
        }

        public void RegisterLocalizations(IServiceCollection services, IMvcBuilder mvcBuilder)
        {
            mvcBuilder.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);
            mvcBuilder.AddDataAnnotationsLocalization();
            mvcBuilder.AddDataAnnotationsLocalization(options =>
            {
                options.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(ValidationMessages));
            });

            services.Configure<LocalizationOptions>(options =>
            {
                options.ResourcesPath = "Resources";
            });

            services.Configure<MvcOptions>(options =>
            {
                options.ModelMetadataDetailsProviders.Add(
                    new CustomValidationMetadataProvider());
            });

            services.Configure<RequestLocalizationOptions>(options =>
                {
                    options.SupportedUICultures = new List<CultureInfo>
                    {
                        new CultureInfo("fr"),
                        new CultureInfo("en"),
                        new CultureInfo("es"),
                        new CultureInfo("pt"),
                    };
                    options.DefaultRequestCulture = new RequestCulture("en");
                }
            );
        }

        private static void RegisterServices(IServiceCollection services)
        {
            NativeInjectorBootstrapper.RegisterServices(services);
        }
    }
}
