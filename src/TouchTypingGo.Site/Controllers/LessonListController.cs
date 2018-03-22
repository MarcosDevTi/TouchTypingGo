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
    public class LessonListController : BaseController
    {
        private readonly ILessonListAppService _lessonListAppService;
       
        public LessonListController(
            IDomainNotificationHandler<DomainDotification> notification, 
            IUser user, 
            ILessonListAppService lessonListAppService) : base(notification, user)
        {
            _lessonListAppService = lessonListAppService;
        }

        // GET: TouchTyppingGo
        public ActionResult Index()
        {
            //var teste = lessonsPreview();
            ////Lista de exercícios
            ////Lista de exercícios com título, parte do texto e resultados
            //var byCategory = _lessonPresentationAppService.GetAll().GroupBy(
            //    x=>x.Category,
            //    x=>x,
            //    (key, g) => new {Category = key, lesson = g.ToList()});

            //var Lessons = byCategory.ToDictionary(t => t.Category, t => t.lesson);
            
            return View(_lessonListAppService.PreviewLessonViewModels());
        }

        //private PreviewLessonViewModel[] lessonsPreview()
        //{
            
        //    return lessonPrw.ToArray();
        //}

        // GET: TouchTyppingGo/Details/5
        public ActionResult Lesson(Guid id)
        {
            
            return View(_lessonListAppService.GetById(id));
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Lesson(AppViewModel appViewModel)
        //{
        //    if (!ModelState.IsValid) return View(appViewModel);
        //    //_lessonListAppService.ad

        //    return View(appViewModel);
        //}

        // GET: TouchTyppingGo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TouchTyppingGo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TouchTyppingGo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TouchTyppingGo/Edit/5
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

        // GET: TouchTyppingGo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TouchTyppingGo/Delete/5
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