using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class LessonPresentationController : BaseController
    {
        private readonly IlessonPresentationAppService _lessonPresentationAppService;

        public LessonPresentationController(IlessonPresentationAppService lessonPresentationAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user) : base(notification, user)
        {
            _lessonPresentationAppService = lessonPresentationAppService;
        }
        // GET: LessonPresentation
        public ActionResult Index()
        {

            return View(_lessonPresentationAppService.GetAll());
        }

        // GET: LessonPresentation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LessonPresentation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LessonPresentation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LessonPresentationViewModel lessonPresentationViewModel)
        {
            if (!ModelState.IsValid) return View(lessonPresentationViewModel);
            _lessonPresentationAppService.Add(lessonPresentationViewModel);

            ViewBag.SuccessCreated = ValidOperation() ? "success,Exercício criado com sucesso!" : "error,O Exercício não foi refistrado, verifique as mensagens";
            return View(lessonPresentationViewModel);
        }

        // GET: LessonPresentation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LessonPresentation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LessonPresentation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LessonPresentation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}