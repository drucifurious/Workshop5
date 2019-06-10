using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using workshop5.Models;

namespace workshop5.Controllers
{
    public class BookingDetailsController : Controller
    {
        private readonly travel_expertsContext _context;

        public BookingDetailsController(travel_expertsContext context)
        {
            _context = context;
        }

        // GET: BookingDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookingDetails.ToListAsync());
        }

        // GET: BookingDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingDetails = await _context.BookingDetails
                .FirstOrDefaultAsync(m => m.BookingDetailId == id);
            if (bookingDetails == null)
            {
                return NotFound();
            }

            return View(bookingDetails);
        }

        // GET: BookingDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookingDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingDetailId,ItineraryNo,TripStart,TripEnd,Description,Destination,BasePrice,AgencyCommission,BookingId,RegionId,ClassId,FeeId,ProductSupplierId")] BookingDetails bookingDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookingDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookingDetails);
        }

        // GET: BookingDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingDetails = await _context.BookingDetails.FindAsync(id);
            if (bookingDetails == null)
            {
                return NotFound();
            }
            return View(bookingDetails);
        }

        // POST: BookingDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingDetailId,ItineraryNo,TripStart,TripEnd,Description,Destination,BasePrice,AgencyCommission,BookingId,RegionId,ClassId,FeeId,ProductSupplierId")] BookingDetails bookingDetails)
        {
            if (id != bookingDetails.BookingDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookingDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingDetailsExists(bookingDetails.BookingDetailId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bookingDetails);
        }

        // GET: BookingDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingDetails = await _context.BookingDetails
                .FirstOrDefaultAsync(m => m.BookingDetailId == id);
            if (bookingDetails == null)
            {
                return NotFound();
            }

            return View(bookingDetails);
        }

        // POST: BookingDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookingDetails = await _context.BookingDetails.FindAsync(id);
            _context.BookingDetails.Remove(bookingDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingDetailsExists(int id)
        {
            return _context.BookingDetails.Any(e => e.BookingDetailId == id);
        }
    }
}
