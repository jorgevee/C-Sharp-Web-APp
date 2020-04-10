using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using DataLib;
using static DataLib.BusinessLogic.EmployeeProcessor;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
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
        public IActionResult SignUp()
        {
            return View();
        }
        //USer form validation then redirect

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(PersonModel model)
        {
            if (ModelState.IsValid)
            {

                int recordsCreated = CreateEmployee(model.EmployeeID,
                    model.FirstName,
                    model.LastName,
                    model.EmailAddress
                    ); 
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}

