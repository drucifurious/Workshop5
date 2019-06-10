using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workshop5.Models;

namespace workshop5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult SignUp()
        {
            ViewData["Message"] = "Your SignUP page.";

            return View();
        }

        public IActionResult Registration()
        {
            ViewData["Message"] = "Please Register to Continue.. .";

            return View();
        }

        public IActionResult Booking()
        {
            ViewData["Message"] = "Please book to Continue.. .";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Packages()
        {
            ViewData["Message"] = "Your Packages page.";

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
    }
}
