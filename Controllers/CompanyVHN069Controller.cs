using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VuHongNgocBTH2.Models;

namespace VuHongNgoc069.Controllers
{
    public class CompanyVHN069Controller : Controller
    {
        private readonly ApplicationDBContext _context;

        public CompanyVHN069Controller(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: CompanyVHN069
        public async Task<IActionResult> Index()
        {
              return _context.CompanyVHN069 != null ? 
                          View(await _context.CompanyVHN069.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.CompanyVHN069'  is null.");
        }

        // GET: CompanyVHN069/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyVHN069 == null)
            {
                return NotFound();
            }

            var companyVHN069 = await _context.CompanyVHN069
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyVHN069 == null)
            {
                return NotFound();
            }

            return View(companyVHN069);
        }

        // GET: CompanyVHN069/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyVHN069/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyVHN069 companyVHN069)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyVHN069);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyVHN069);
        }

        // GET: CompanyVHN069/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyVHN069 == null)
            {
                return NotFound();
            }

            var companyVHN069 = await _context.CompanyVHN069.FindAsync(id);
            if (companyVHN069 == null)
            {
                return NotFound();
            }
            return View(companyVHN069);
        }

        // POST: CompanyVHN069/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyVHN069 companyVHN069)
        {
            if (id != companyVHN069.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyVHN069);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyVHN069Exists(companyVHN069.CompanyId))
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
            return View(companyVHN069);
        }

        // GET: CompanyVHN069/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyVHN069 == null)
            {
                return NotFound();
            }

            var companyVHN069 = await _context.CompanyVHN069
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyVHN069 == null)
            {
                return NotFound();
            }

            return View(companyVHN069);
        }

        // POST: CompanyVHN069/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyVHN069 == null)
            {
                return Problem("Entity set 'ApplicationDBContext.CompanyVHN069'  is null.");
            }
            var companyVHN069 = await _context.CompanyVHN069.FindAsync(id);
            if (companyVHN069 != null)
            {
                _context.CompanyVHN069.Remove(companyVHN069);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyVHN069Exists(string id)
        {
          return (_context.CompanyVHN069?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}
