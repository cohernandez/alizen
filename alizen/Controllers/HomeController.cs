using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using alizen.Models;


namespace alizen.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Post()
        {
            ViewBag.Message="Listar los Post de Instructores";
            return View();
        }

        public IActionResult Index()
        {
            int hour= DateTime.Now.Hour;
            ViewBag.Greeting = hour<12? "Good Morning" : "Good:Afternoom";
            
            ViewBag.Message="VideoDemo de los Servicios de la Academia de Aline";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Message="Politica de privacidad y uso de datos";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message="Servicios profesionales de salud, bienestar y venta de productos y Asesorias nutricionales";
            return View();
        }

        public IActionResult Reserva()
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
