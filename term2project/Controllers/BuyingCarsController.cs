using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using term2project.Data;
using term2project.Models;

namespace term2project.Controllers
{
    public class BuyingCarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BuyingCarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BuyingCars
        public async Task<IActionResult> Index()
        {
              return _context.BuyingCar != null ? 
                          View(await _context.BuyingCar.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.BuyingCar'  is null.");
        }

        // GET: BuyingCars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BuyingCar == null)
            {
                return NotFound();
            }

            var buyingCar = await _context.BuyingCar
                .FirstOrDefaultAsync(m => m.ID == id);
            if (buyingCar == null)
            {
                return NotFound();
            }

            return View(buyingCar);
        }

        // GET: BuyingCars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BuyingCars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,BankNumber,PhoneNumber")] BuyingCar buyingCar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(buyingCar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(buyingCar);
        }

        // GET: BuyingCars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BuyingCar == null)
            {
                return NotFound();
            }

            var buyingCar = await _context.BuyingCar.FindAsync(id);
            if (buyingCar == null)
            {
                return NotFound();
            }
            return View(buyingCar);
        }

        // POST: BuyingCars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,BankNumber,PhoneNumber")] BuyingCar buyingCar)
        {
            if (id != buyingCar.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buyingCar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuyingCarExists(buyingCar.ID))
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
            return View(buyingCar);
        }

        // GET: BuyingCars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BuyingCar == null)
            {
                return NotFound();
            }

            var buyingCar = await _context.BuyingCar
                .FirstOrDefaultAsync(m => m.ID == id);
            if (buyingCar == null)
            {
                return NotFound();
            }

            return View(buyingCar);
        }

        // POST: BuyingCars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BuyingCar == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BuyingCar'  is null.");
            }
            var buyingCar = await _context.BuyingCar.FindAsync(id);
            if (buyingCar != null)
            {
                _context.BuyingCar.Remove(buyingCar);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BuyingCarExists(int id)
        {
          return (_context.BuyingCar?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
