using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class BaseController : Controller
    {
        private readonly IDomainNotificationHandler<DomainDotification> _notification;

        public BaseController(IDomainNotificationHandler<DomainDotification> notification)
        {
            _notification = notification;
        }

        protected bool ValidOperation()
        {
            return (!_notification.HasNotifications());
        }
    }
}
