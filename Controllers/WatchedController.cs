using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MVCmovietracker.Controllers
{
    public class WatchedController : Controller
    {
        private readonly Context _context;

        public WatchedController(Context context)
        {
            _context = context;
        }

        // GET: Watched
        public async Task<IActionResult> Index()
        {
              return _context.Watched != null ? 
                          View(await _context.Watched.ToListAsync()) :
                          Problem("Entity set 'Context.Watched'  is null.");
        }

        // GET: Watched/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Watched == null)
            {
                return NotFound();
            }

            var watched = await _context.Watched
                .FirstOrDefaultAsync(m => m.ID == id);
            if (watched == null)
            {
                return NotFound();
            }

            return View(watched);
        }

        // GET: Watched/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Watched/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Director,Summary")] Watched watched)
        {
            if (ModelState.IsValid)
            {
                _context.Add(watched);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(watched);
        }

        // GET: Watched/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Watched == null)
            {
                return NotFound();
            }

            var watched = await _context.Watched.FindAsync(id);
            if (watched == null)
            {
                return NotFound();
            }
            return View(watched);
        }

        // POST: Watched/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Director,Summary")] Watched watched)
        {
            if (id != watched.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(watched);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WatchedExists(watched.ID))
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
            return View(watched);
        }

        // GET: Watched/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Watched == null)
            {
                return NotFound();
            }

            var watched = await _context.Watched
                .FirstOrDefaultAsync(m => m.ID == id);
            if (watched == null)
            {
                return NotFound();
            }

            return View(watched);
        }

        // POST: Watched/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Watched == null)
            {
                return Problem("Entity set 'Context.Watched'  is null.");
            }
            var watched = await _context.Watched.FindAsync(id);
            if (watched != null)
            {
                _context.Watched.Remove(watched);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WatchedExists(int id)
        {
          return (_context.Watched?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
