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
    public class LessonResultController : BaseController
    {
        private readonly IlessonResultAppService _lessonResultAppService;
        private readonly IlessonPresentationAppService _lessonPresentationAppService;
        public LessonResultController(
            IlessonResultAppService lessonResultAppService,
            IlessonPresentationAppService lessonPresentationAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user) : base(notification, user)
        {
            _lessonResultAppService = lessonResultAppService;
            _lessonPresentationAppService = lessonPresentationAppService;
        }

        // GET: LessonResult
        public ActionResult Index()
        {
            return View(_lessonResultAppService.GetAll());
        }

        // GET: LessonResult/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LessonResult/Create
        public ActionResult Create()
        {
            ViewBag.lessonPresentations = _lessonResultAppService.lessonsPresentationsSelect();
            return View();
        }

        // POST: LessonResult/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LessonResultViewModel lessonResult)
        {
            if (!ModelState.IsValid) return View(lessonResult);
            _lessonResultAppService.Add(lessonResult);

            ViewBag.SuccessCreated = ValidOperation() ? "success,Resultado do Exercício criado com sucesso!" : "error,O Resultado do Exercício não foi refistrado, verifique as mensagens";
            return View(lessonResult);
        }

        // GET: LessonResult/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LessonResult/Edit/5
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

        // GET: LessonResult/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LessonResult/Delete/5
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