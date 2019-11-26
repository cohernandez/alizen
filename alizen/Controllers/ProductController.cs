using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using alizen.Models;

namespace alizen.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<string> products = new List<string>(){
                "Book",
                "T-Short",
                "Path",
                "Nutrición plan"
            };
            return View(products);
        }

        public IActionResult ProductDetail()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
