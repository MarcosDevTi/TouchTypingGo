using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.ComponentModel;
using System.Linq;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    //[MiddlewareFilter(typeof(LocalizationPipeline))]
    public class BaseController : Controller
    {
        private readonly IDomainNotificationHandler<DomainDotification> _notification;
        protected readonly IUser _user;
        protected readonly IStringLocalizer<BaseController> Localizer;

        public Guid? StudentId { get; set; }
        public Guid? TeacherId { get; set; }
        public BaseController(IDomainNotificationHandler<DomainDotification> notification, IUser user, IStringLocalizer<BaseController> localizer)
        {
            _notification = notification;
            _user = user;
            Localizer = localizer;

            if (!_user.IsAuthenticated()) return;
            StudentId = _user.GetUderId();
            TeacherId = _user.GetUderId();
        }

        protected bool ValidOperation()
        {
            return !_notification.HasNotifications();
        }

        public string GetMessageCreate(object obj)
        {
            var displayName = obj.GetType().GetCustomAttributes(typeof(DisplayNameAttribute), true)
                .FirstOrDefault() as DisplayNameAttribute;

            return ValidOperation()
                ? $"success,{Localizer["EntityCreated", Localizer[displayName?.DisplayName]]}!"
                : $"error,{Localizer["InstitutionNotCreated"]}, {Localizer["checkTheMessages"]}";
        }
    }
}
