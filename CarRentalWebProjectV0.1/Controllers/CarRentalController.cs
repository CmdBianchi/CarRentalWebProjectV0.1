﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public IActionResult NewCarRental() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewCarRental(CarRental carRental) {
            await _context.CarRentals.AddAsync(carRental);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
