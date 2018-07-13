using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using TouchTypingGo.Application.Cqrs.Query.Queries;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Domain.Core.Cqrs;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class LessonListController : BaseController
    {
        private readonly ILessonListAppService _lessonListAppService;
        private readonly ILessonPresentationAppService _lessonPresentationAppService;
        private readonly IProcessor _processor;

        public LessonListController(
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user,
            ILessonListAppService lessonListAppService, ILessonPresentationAppService lessonPresentationAppService,
            IStringLocalizer<BaseController> localizer, IProcessor processor) : base(notification, user, localizer)
        {
            _lessonListAppService = lessonListAppService;
            _lessonPresentationAppService = lessonPresentationAppService;
            _processor = processor;
        }

        [Route("learning-lesson/{id:guid}")]
        public IActionResult App(Guid id)
        {
            //var lesson = _lessonPresentationAppService.GetById(id);
            return View(_processor.Process(new GetLessonPresentationApp(id)));
        }

        [Route("my-lessons")]
        public IActionResult Index()
        {
            return View(_lessonListAppService.PreviewLessonViewModels());
        }

        [Route("learning-lesson-details/{id:guid}")]
        public IActionResult Lesson(Guid id)
        {

            return View(_lessonListAppService.GetById(id));
        }
    }
}