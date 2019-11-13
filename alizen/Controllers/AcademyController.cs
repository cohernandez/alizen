using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using alizen.Models;

namespace alizen.Controllers
{
    public class AcademyController : Controller
    {
        public IActionResult Index()
        {
            List<string> countries = new List<string>(){
                "Francia",
                "Chile",
                "Italia",
                "Mexico"
            };
            return View(countries);
        }

        public IActionResult Privacy()
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
