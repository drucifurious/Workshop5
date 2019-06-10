﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workshop5.Models;
using workshop5.Controllers;
using Microsoft.EntityFrameworkCore;

namespace workshop5.Controllers
{
    public class HomeController : Controller
    {
        private readonly travel_expertsContext _context;

        public HomeController(travel_expertsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Packages.ToListAsync());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult SignIn()
        {
            ViewData["Message"] = "Your SignIn page.";

            return View();
        }

        public IActionResult SignUp()
        {
            ViewData["Message"] = "Please Sign-Up to Continue.. .";

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,BookingDate,BookingNo,TravelerCount,CustomerId,TripTypeId,PackageId")] Bookings bookings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookings);
        }
    }
}
