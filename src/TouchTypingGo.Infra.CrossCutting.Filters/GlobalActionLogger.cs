using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.Extensions.Hosting;

namespace TouchTypingGo.Infra.CrossCutting.Filters
{
    public class GlobalActionLogger : IActionFilter
    {
        private readonly ILogger<GlobalActionLogger> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;

        public GlobalActionLogger(ILogger<GlobalActionLogger> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (_hostingEnvironment.IsDevelopment())
            {
                var data = new
                {
                    Version = "v1.0",
                    User = context.HttpContext.User.Identity.Name,
                    IP = context.HttpContext.Connection.RemoteIpAddress.ToString(),
                    Hostname = context.HttpContext.Request.Host.ToString(),
                    AreaAccessed = context.HttpContext.Request.GetDisplayUrl(),
                    Action = context.ActionDescriptor.DisplayName,
                    TimeStamp = DateTime.Now
                };
                //_logger.LogInformation(1, data.ToString(), "Log of audit data.");
            }
            if (_hostingEnvironment.IsProduction())
            {
                //elmah.io

                //send the object type of CreateMessage to Elmah
            }
        }


        public void OnActionExecuting(ActionExecutingContext context)
        {
            //throw new System.NotImplementedException();
        }


    }
}
