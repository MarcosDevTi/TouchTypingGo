using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TouchTypingGo.Application.Cqrs.Query.Queries;
using TouchTypingGo.Application.Cqrs.Query.Queries.LessonPresentation;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Cqrs;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class LessonPresentationController : BaseController
    {
        private readonly ILessonPresentationAppService _lessonPresentationAppService;
        private readonly IProcessor _processor;

        public LessonPresentationController(
            ILessonPresentationAppService lessonPresentationAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user,
            IStringLocalizer<BaseController> localizer, IProcessor processor) : base(notification, user, localizer)
        {
            _lessonPresentationAppService = lessonPresentationAppService;
            _processor = processor;
        }
        [Route("lessons-presentations")]
        public IActionResult Index()
        {
            return View(_processor.Process(new GetLessonPresentationsIndex()));
        }

        [Route("new-lesson-presentation")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken, Route("new-lesson-presentation")]
        public IActionResult Create(LessonPresentationViewModel lessonPresentationViewModel)
        {
            if (!ModelState.IsValid) return View(lessonPresentationViewModel);
            _lessonPresentationAppService.Add(lessonPresentationViewModel);

            ViewBag.SuccessCreated = GetMessageCreate(lessonPresentationViewModel);
            return View(lessonPresentationViewModel);
        }
    }
}