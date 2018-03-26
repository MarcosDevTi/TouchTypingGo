using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TouchTypingGo.Infra.CrossCutting.Identity.Models;

namespace TouchTypingGo.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
