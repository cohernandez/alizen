using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using alizen.Models;

namespace alizen.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            List<string> paises = new List<string>(){
                "Francia",
                "Chile",
                "Italia",
                "Mexico"
            };
            return View(paises);
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
