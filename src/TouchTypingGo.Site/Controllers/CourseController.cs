using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using Microsoft.AspNetCore.Authorization;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class CourseController : BaseController
    {
        private readonly ICourseAppService _courseAppService;
        private readonly ILessonPresentationAppService _lessonPresentationAppService;

        public CourseController(ICourseAppService courseAppService,
            IDomainNotificationHandler<DomainDotification> notifications,
            IUser user, ILessonPresentationAppService lessonPresentationAppService,
            IStringLocalizer<BaseController> localizer) : base(notifications, user, localizer)
        {
            _courseAppService = courseAppService;
            _lessonPresentationAppService = lessonPresentationAppService;
        }

        [Route("courses"), Authorize(Policy = "CanReadCourses")]
        public IActionResult Index()
        {
            return View(_courseAppService.GetAll());
        }

        [Route("new-course"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Create()
        {
            ViewBag.UserLessons = _lessonPresentationAppService.GetAll();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken, Route("new-course"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Create(CourseViewModel courseViewModel)
        {

            if (!ModelState.IsValid) return View(courseViewModel);
            var code = _courseAppService.Add(courseViewModel);

            ViewBag.SuccessCreated = GetMessageCreate(courseViewModel);
            return View(courseViewModel);
        }


        [Route("add-lesson-in-course/{id:guid}"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult AddLesson(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courseViewModel = _courseAppService.GetById(id.Value);

            return PartialView("_AddLesson", courseViewModel);
        }

        [Route("update-course"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Edit(Guid id)
        {
            var course = _courseAppService.GetById(id);
            return View(course);
        }

        [HttpPost, ValidateAntiForgeryToken, Route("update-course"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Edit(CourseViewModel courseViewModel)
        {
            if (ModelState.IsValid) return View(courseViewModel);
            _courseAppService.Update(courseViewModel);
            //TODO: Validation if success!
            return View(courseViewModel);
        }

        [Route("delete-course/{id:guid}"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courseViewModel = _courseAppService.GetById(id.Value);
            return View(courseViewModel);
        }

        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken, Route("delete-course/{id:guid}"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _courseAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}