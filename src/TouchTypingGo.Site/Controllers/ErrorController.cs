using Microsoft.AspNetCore.Mvc;
using TouchTypingGo.Domain.Core.Interfaces;

namespace TouchTypingGo.Site.Controllers
{
    public class ErrorController : Controller
    {
        private readonly IUser _user;

        public ErrorController(IUser user)
        {
            _user = user;
        }


        [Route("/error"), Route("/error/{id}")]
        public IActionResult Error(string id)
        {
            switch (id)
            {
                case "404":
                    return View("NotFound");
                case "500":
                    return View("ServerError");
                case "403":
                case "401":
                    if (!_user.IsAuthenticated()) return RedirectToAction("Login", "Account");
                    return View("AccessDenied");
                    default:
                        return View("Error");
            }
            
        }
    }
}