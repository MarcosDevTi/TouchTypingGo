using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.UI.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseAppService _courseAppService;

        public CourseController(ICourseAppService courseAppService)
        {
            _courseAppService = courseAppService;
        }
        // GET: Course
        public IActionResult Index()
        {
            return View(_courseAppService.GetAll());
        }

        // GET: Course/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courseViewModel = _courseAppService.GetById(id.Value);
            return View(courseViewModel);
        }

        // GET: Course/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CourseViewModel courseViewModel)
        {
            if (!ModelState.IsValid) return View(courseViewModel);
           _courseAppService.Add(courseViewModel);

            return View(courseViewModel);
        }

        // GET: Course/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CourseViewModel courseViewModel)
        {
            if (ModelState.IsValid) return View(courseViewModel);
            _courseAppService.Update(courseViewModel);
            //TODO: Validar se operação occoreu com sucesso!
            return View(courseViewModel);
        }

        // GET: Course/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var courseViewModel = _courseAppService.GetById(id.Value);
            return View(courseViewModel);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
           _courseAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}