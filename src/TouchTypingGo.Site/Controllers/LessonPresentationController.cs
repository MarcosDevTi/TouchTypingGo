using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Infra.CrossCutting.CookieManager;

namespace TouchTypingGo.Site.Controllers
{
    public class LessonPresentationController : BaseController
    {
        private readonly ILessonPresentationAppService _lessonPresentationAppService;
        private readonly ICookie _cookie;

        public LessonPresentationController(ILessonPresentationAppService lessonPresentationAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user, ICookie cookie,
            IStringLocalizer<BaseController> localizer) : base(notification, user, localizer)
        {
            _lessonPresentationAppService = lessonPresentationAppService;
            _cookie = cookie;
        }
        public IActionResult Index()
        {
            return View(_lessonPresentationAppService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LessonPresentationViewModel lessonPresentationViewModel)
        {
            if (!ModelState.IsValid) return View(lessonPresentationViewModel);
            _lessonPresentationAppService.Add(lessonPresentationViewModel);

            ViewBag.SuccessCreated = GetMessageCreate(lessonPresentationViewModel);
            return View(lessonPresentationViewModel);
        }
    }
}