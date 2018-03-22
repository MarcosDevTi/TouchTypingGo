using System;
using Microsoft.AspNetCore.Mvc;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class CourseController : BaseController
    {
        private readonly ICourseAppService _courseAppService;
        private readonly IlessonPresentationAppService _lessonPresentationAppService;

        public CourseController(ICourseAppService courseAppService,
            IDomainNotificationHandler<DomainDotification> notifications,
            IUser user, IlessonPresentationAppService lessonPresentationAppService) : base(notifications, user)
        {
            _courseAppService = courseAppService;
            _lessonPresentationAppService = lessonPresentationAppService;
        }

        public IActionResult Index()
        {
            return View(_courseAppService.GetAll());
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courseViewModel = _courseAppService.GetById(id.Value);
            return View(courseViewModel);
        }

        public IActionResult Create()
        {
            ViewBag.UserLessons = _lessonPresentationAppService.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CourseViewModel courseViewModel)
        {
           
            if (!ModelState.IsValid) return View(courseViewModel);
           var code = _courseAppService.Add(courseViewModel);

            ViewBag.SuccessCreated = ValidOperation() ? $"success,Curso criado com sucesso. O código gerado é: {code}" : "error,O curso não foi refistrado, verifique as mensagens";
            return View(courseViewModel);
        }

        public IActionResult Edit(Guid id)
        {
            var course = _courseAppService.GetById(id);
            return View(course);
        }

        public IActionResult AddLesson(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courseViewModel = _courseAppService.GetById(id.Value);

            return PartialView("_AddLesson", courseViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CourseViewModel courseViewModel)
        {
            if (ModelState.IsValid) return View(courseViewModel);
            _courseAppService.Update(courseViewModel);
            //TODO: Validar se operação occoreu com sucesso!
            return View(courseViewModel);
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courseViewModel = _courseAppService.GetById(id.Value);
            return View(courseViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
           _courseAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}