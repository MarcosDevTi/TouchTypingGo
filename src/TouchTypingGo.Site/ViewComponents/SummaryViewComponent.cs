using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.ViewComponents
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly IDomainNotificationHandler<DomainDotification> _notifications;

        public SummaryViewComponent(IDomainNotificationHandler<DomainDotification> notification)
        {
            _notifications = notification;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notifications = await Task.FromResult(_notifications.GetNotifications());
            notifications.ForEach(c=> ViewData.ModelState.AddModelError(string.Empty, c.Value));

            return View();
        }
    }
}
