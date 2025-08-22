using Microsoft.AspNetCore.Mvc;

namespace Firstproject.Asp.Net.Core.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost,HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
