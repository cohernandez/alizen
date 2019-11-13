using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using alizen.Models;


namespace alizen.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogDetail()
        {
            ViewBag.Message="Descripcion resumida del blog";
            return View();
        }

        public IActionResult ResumeLastPost()
        {
            ViewBag.Message="Obtener el ultimo Post";
            return View();
        }

        public IActionResult GetInstructor()
        {
            ViewBag.Message="Obtener detaller del instructor";
            return View();
        }

        public IActionResult ProductsList()
        {
            ViewBag.Message="Obtener lista de productos asociados en tiendita";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
