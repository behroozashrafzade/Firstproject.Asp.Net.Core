using Microsoft.AspNetCore.Mvc;
using Firstproject.Asp.Net.Core.Models; // Assuming User model is defined in this namespace

namespace Firstproject.Asp.Net.Core.Controllers
{
    public class AdminController : Controller
    {
        User myUser = new User();

        List<User> users = new List<User>();



        public IActionResult Index()
        {

            ViewBag.SSsss = "Hello from Admin Controller Index Action";



            return View();
        }

        public IActionResult UserList()
        {
            users.Add(
             new User
             {
                 UserId = Guid.NewGuid(),
                 UserName = "11111111111",
                 UserPassword = "1111111111",
                 UserEmail = "111111",
                 UserPhone = "11111"
             });

            users.Add(
             new User
             {
                 UserId = Guid.NewGuid(),
                 UserName = "222222222222",
                 UserPassword = "22222222222",
                 UserEmail = "2222",
                 UserPhone = "2222"
             });


            users.Add(
            new User
            {
                UserId = Guid.NewGuid(),
                UserName = "3333333",
                UserPassword = "333333",
                UserEmail = "33333",
                UserPhone = "33333"
            });


            return View(users);
        }



        public IActionResult Details(Guid id)
        {
            User? temp=users.Find(a=>a.UserId==id);


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
