using Microsoft.AspNetCore.Mvc;
using Firstproject.Asp.Net.Core.Models; // Assuming User model is defined in this namespace

namespace Firstproject.Asp.Net.Core.Controllers
{
    public class AdminController : Controller
    {
        Admin myUser = new Admin();

        List<Admin> Admins = new List<Admin>();



        public IActionResult Index()
        {

            ViewBag.SSsss = "Hello from Admin Controller Index Action";



            return View();
        }

        public IActionResult UserList()
        {
            Admins.Add(
             new Admin
             {
                 AdminId = Guid.NewGuid(),
                 AdminUserName = "11111111111",
                 AdminPassword = "1111111111",
                 AdminEmail = "111111",
                 AdminPhone = "11111"
             });

            Admins.Add(
             new Admin
             {
                 AdminId = Guid.NewGuid(),
                 AdminUserName = "222222222222",
                 AdminPassword = "22222222222",
                 AdminEmail = "2222",
                 AdminPhone = "2222"
             });


            Admins.Add(
            new Admin
            {
                AdminId = Guid.NewGuid(),
                AdminUserName = "3333333",
                AdminPassword = "333333",
                AdminEmail = "33333",
                AdminPhone = "33333"
            });


            return View(Admins);
        }



        public IActionResult Details(Guid id)
        {
            Admin? temp= Admins.Find(a=>a.AdminId== id);


            return View(temp);


        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update(Guid id)
        {
            return View();

        }
        public IActionResult Delete(Guid id)
        {
            return View();

        }

    }
}
