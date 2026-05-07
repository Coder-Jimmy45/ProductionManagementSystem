using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductionManagementSystem.Data;
using ProductionManagementSystem.Models;

namespace ProductionManagementSystem.Controllers
{
    public class ProductionEntriesController : Controller
    {
        private readonly AppDbContext _context;

        public ProductionEntriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ProductionEntries
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductionEntries.ToListAsync());
        }

        // GET: ProductionEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionEntry = await _context.ProductionEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productionEntry == null)
            {
                return NotFound();
            }

            return View(productionEntry);
        }

        // GET: ProductionEntries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductionEntries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,QuantityProduced,EntryDate")] ProductionEntry productionEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productionEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productionEntry);
        }

        // GET: ProductionEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionEntry = await _context.ProductionEntries.FindAsync(id);
            if (productionEntry == null)
            {
                return NotFound();
            }
            return View(productionEntry);
        }

        // POST: ProductionEntries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductName,QuantityProduced,EntryDate")] ProductionEntry productionEntry)
        {
            if (id != productionEntry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productionEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductionEntryExists(productionEntry.Id))
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
            return View(productionEntry);
        }

        // GET: ProductionEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionEntry = await _context.ProductionEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productionEntry == null)
            {
                return NotFound();
            }

            return View(productionEntry);
        }

        // POST: ProductionEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productionEntry = await _context.ProductionEntries.FindAsync(id);
            if (productionEntry != null)
            {
                _context.ProductionEntries.Remove(productionEntry);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductionEntryExists(int id)
        {
            return _context.ProductionEntries.Any(e => e.Id == id);
        }
    }
}
