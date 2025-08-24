using Microsoft.AspNetCore.Mvc;
using Firstproject.Asp.Net.Core.Models; // Assuming Product model is defined in this namespace

namespace Firstproject.Asp.Net.Core.Controllers
{
    public class ProductController : Controller
    {
        Product MyProduct = new Product();

         List<Product> products = new List<Product>();
        public ProductController()
        {
            MyProduct.ProductId=Guid.NewGuid();
            MyProduct.ProductName="Laptop";
            MyProduct.ProductDescription="This is a high-performance laptop suitable for all your computing needs.";
            MyProduct.ProductPrice=999.99M;

            products.Add(MyProduct);
        }


        public IActionResult ShowProduct()
        {


            return View(products);
        }

        public IActionResult Delete()
        {
            return View();
        }

        // Additional actions like Create, Edit, Details can be added here

         public IActionResult Details()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }


    }
}
