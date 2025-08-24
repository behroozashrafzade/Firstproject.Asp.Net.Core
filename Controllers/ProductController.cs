using Microsoft.AspNetCore.Mvc;
using Firstproject.Asp.Net.Core.Models; // Assuming Product model is defined in this namespace

namespace Firstproject.Asp.Net.Core.Controllers
{
    public class ProductController : Controller
    {


        public IActionResult ShowProduct()
        {


            return View();
        }
    }
}
