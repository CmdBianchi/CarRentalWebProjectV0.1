using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Microsoft.EntityFrameworkCore;
namespace Controllers {
    public class CarRentalController : Controller {

        private readonly Context _context;

        public CarRentalController(Context context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            return View(await _context.CarRentals.ToListAsync());
        }

        [HttpGet] // --- > NEW CLIENT BUTTON
        public IActionResult NewCarRental() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewCarRental(CarRental carRental) {
            await _context.CarRentals.AddAsync(carRental);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet] // --- > UPDATE BUTTON
        public async Task<IActionResult> Update(int carRentalId) {
            CarRental carRental = await _context.CarRentals.FindAsync(carRentalId);

            return View(carRental);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CarRental carRental) {
            _context.CarRentals.Update(carRental);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost] // --- > DELETE BUTTON
        public async Task<IActionResult> Delete(int carRentalId) {
            CarRental carRental = await _context.CarRentals.FindAsync(carRentalId);
            _context.CarRentals.Remove(carRental);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }  
    }
}
