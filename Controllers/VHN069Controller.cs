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
    public class VHN069Controller : Controller
    {
        private readonly ApplicationDBContext _context;

        public VHN069Controller(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: VHN069
        public async Task<IActionResult> Index()
        {
              return _context.VHN069 != null ? 
                          View(await _context.VHN069.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.VHN069'  is null.");
        }

        // GET: VHN069/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.VHN069 == null)
            {
                return NotFound();
            }

            var vHN069 = await _context.VHN069
                .FirstOrDefaultAsync(m => m.VHNId == id);
            if (vHN069 == null)
            {
                return NotFound();
            }

            return View(vHN069);
        }

        // GET: VHN069/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VHN069/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VHNId,VHNName,VHNGender")] VHN069 vHN069)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vHN069);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vHN069);
        }

        // GET: VHN069/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.VHN069 == null)
            {
                return NotFound();
            }

            var vHN069 = await _context.VHN069.FindAsync(id);
            if (vHN069 == null)
            {
                return NotFound();
            }
            return View(vHN069);
        }

        // POST: VHN069/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VHNId,VHNName,VHNGender")] VHN069 vHN069)
        {
            if (id != vHN069.VHNId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vHN069);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VHN069Exists(vHN069.VHNId))
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
            return View(vHN069);
        }

        // GET: VHN069/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.VHN069 == null)
            {
                return NotFound();
            }

            var vHN069 = await _context.VHN069
                .FirstOrDefaultAsync(m => m.VHNId == id);
            if (vHN069 == null)
            {
                return NotFound();
            }

            return View(vHN069);
        }

        // POST: VHN069/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.VHN069 == null)
            {
                return Problem("Entity set 'ApplicationDBContext.VHN069'  is null.");
            }
            var vHN069 = await _context.VHN069.FindAsync(id);
            if (vHN069 != null)
            {
                _context.VHN069.Remove(vHN069);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VHN069Exists(string id)
        {
          return (_context.VHN069?.Any(e => e.VHNId == id)).GetValueOrDefault();
        }
    }
}
