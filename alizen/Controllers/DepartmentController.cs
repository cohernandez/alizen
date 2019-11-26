using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using System.Net;

using Microsoft.AspNetCore.Mvc;
using alizen.Models;


namespace alizen.Controllers
{
    public class DepartmentController : Controller
    {
        
        // private StoreContext db = new StoreContext(); 

        // Get: Departments
        public IActionResult Index()
        {
            ViewBag.Message="Listar los Departamentos";
            return View();
        }

        public IActionResult Details(int? Id)
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
