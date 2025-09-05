using Firstproject.Asp.Net.Core.Models;
using Firstproject.Asp.Net.Core.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Project;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
namespace Firstproject.Asp.Net.Core.Controllers
{
    public class UsersController : Controller
    {
       // User myUser = new User();

        List<User> myUsers = new List<User>();

        public UsersController()
        {
            myUsers.Add(
             new User
             {
                 UserId = Guid.NewGuid(),
                 UserName = "user1",
                 UserPassword = "user1",
                 UserEmail = "user1",
                 UserPhone = "user1"
             });

            myUsers.Add(
             new User
             {
                 UserId = Guid.NewGuid(),
                 UserName = "user2",
                 UserPassword = "user2",
                 UserEmail = "user2",
                 UserPhone = "user2"
             });


            myUsers.Add(
            new User
            {
                UserId = Guid.NewGuid(),
                UserName = "user3",
                UserPassword = "user3",
                UserEmail = "user3",
                UserPhone = "user3"
            });
        }
        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult UsersList()
        {
            return View(myUsers);

        }
        [HttpGet]
        public IActionResult Singup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Singup(CreateUser ? CreateUsertemp)
        {
            if(ModelState.IsValid)
            {
                 User usertemp =  new User()
                 {
                     

                    UserId = Guid.NewGuid(),
                    UserName = CreateUsertemp.UserName,
                    UserPassword = CreateUsertemp.UserPassword,
                    UserEmail = CreateUsertemp.UserEmail,
                    UserPhone = CreateUsertemp.UserPhone



                
                 };

                myUsers.Add(usertemp);
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
            
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
