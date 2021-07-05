using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Electricad.Data;

namespace Electricad.Controllers
{
    [Area("Admin")]
    public class OffersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OffersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Offers
        public async Task<IActionResult> Index()
        {
            return View(await _context.tb_offers.ToListAsync());
        }

        // GET: Offers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offers = await _context.tb_offers
                .FirstOrDefaultAsync(m => m.id == id);
            if (offers == null)
            {
                return NotFound();
            }

            return View(offers);
        }

        // GET: Offers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Offers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descount,offer_file,desc")] Offers offers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(offers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(offers);
        }

        // GET: Offers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offers = await _context.tb_offers.FindAsync(id);
            if (offers == null)
            {
                return NotFound();
            }
            return View(offers);
        }

        // POST: Offers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descount,offer_file,desc")] Offers offers)
        {
            if (id != offers.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(offers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OffersExists(offers.id))
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
            return View(offers);
        }

        // GET: Offers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offers = await _context.tb_offers
                .FirstOrDefaultAsync(m => m.id == id);
            if (offers == null)
            {
                return NotFound();
            }

            return View(offers);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offers = await _context.tb_offers.FindAsync(id);
            _context.tb_offers.Remove(offers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OffersExists(int id)
        {
            return _context.tb_offers.Any(e => e.id == id);
        }
    }
}
