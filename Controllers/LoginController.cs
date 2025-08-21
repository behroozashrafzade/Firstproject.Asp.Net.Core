using Microsoft.AspNetCore.Mvc;

namespace Firstproject.Asp.Net.Core.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
