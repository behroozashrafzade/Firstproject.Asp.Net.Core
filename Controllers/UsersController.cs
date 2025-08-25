using Microsoft.AspNetCore.Mvc;

namespace Firstproject.Asp.Net.Core.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult UsersList()
        {
            return View();

        }


        public IActionResult Singup()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult UserProfile()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }

        public IActionResult Logout() 
        {
        
            return View();
        }

        public IActionResult DeleteAccount() 
        {
            return View();
        }

        public IActionResult CreateAccount() 
            {
                return View();
            }

        

    }
}
