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

        public IActionResult AdminList()
        {
            Admins.Add(
             new Admin
             {
                 AdminId = Guid.NewGuid(),
                 AdminUserName = "admin1",
                 AdminPassword = "admin1",
                 AdminEmail = "admin1",
                 AdminPhone = "admin1"
             });

            Admins.Add(
             new Admin
             {
                 AdminId = Guid.NewGuid(),
                 AdminUserName = "admin2",
                 AdminPassword = "admin2",
                 AdminEmail = "admin2",
                 AdminPhone = "admin2"
             });


            Admins.Add(
            new Admin
            {
                AdminId = Guid.NewGuid(),
                AdminUserName = "admin3",
                AdminPassword = "admin3",
                AdminEmail = "admin3",
                AdminPhone = "admin3"
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
