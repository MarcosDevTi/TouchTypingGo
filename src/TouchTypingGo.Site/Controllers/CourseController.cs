using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using TouchTypingGo.Application.Cqrs.Command.Course;
using TouchTypingGo.Application.Cqrs.Query.Models.Course;
using TouchTypingGo.Application.Cqrs.Query.Queries;
using TouchTypingGo.Application.Cqrs.Query.Queries.Course;
using TouchTypingGo.Application.Cqrs.Query.Queries.LessonPresentation;
using TouchTypingGo.Domain.Core.Cqrs;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class CourseController : BaseController
    {
        private readonly IProcessor _processor;

        public CourseController(
            IDomainNotificationHandler<DomainDotification> notifications,
            IUser user,
            IStringLocalizer<BaseController> localizer,
            IProcessor processor,
            IServiceProvider service)
            : base(notifications, user, localizer)
        {
            _processor = processor;
        }

        [Route("courses"), Authorize(Policy = "CanReadCourses")]
        public IActionResult Index() => View(_processor.Process(new GetCoursesIndex()));

        [Route("new-course"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Create()
        {
            ViewBag.UserLessons = _processor.Process(new GetLessonPresentationsIndex());
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken, Route("new-course"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Create(CreateCourse course)
        {

            if (!ModelState.IsValid) return View(course);
            _processor.Send(course);

            ViewBag.SuccessCreated = GetMessageCreate(course);
            return View(course);
        }


        [Route("add-lesson-in-course/{id:guid}"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult AddLesson(Guid? id)
        {
            if (id == null)
                return NotFound();

            var course = _processor.Process(new GetCourseEditDetails(id.Value));

            return PartialView("_AddLesson", course);
        }

        [Route("update-course"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Edit(Guid id)
        {
            var course = _processor.Process(new GetCourseEditDetails(id));
            return View(course);
        }

        [HttpPost, ValidateAntiForgeryToken, Route("update-course"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Edit(CourseEditDetails course)
        {
            if (ModelState.IsValid) return View(course);
            _processor.Send(course);
            //TODO: Validation if success!
            return View(course);
        }

        [Route("delete-course/{id:guid}"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courseViewModel = _processor.Process(new GetCourseDeleteDetails(id.Value));
            return View(courseViewModel);
        }

        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken, Route("delete-course/{id:guid}"), Authorize(Policy = "CanWriteCourses")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _processor.Send(new DeleteCourse(id));
            return RedirectToAction("Index");
        }
    }
}