using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using conway.Data;
using conway.Models;

namespace conway.Controllers
{
    public class ConwaysController : Controller
    {
        private readonly conwayContext _context;

        public ConwaysController(conwayContext context)
        {
            _context = context;
        }

        // GET: Conways
        public async Task<IActionResult> Index()
        {
              return _context.Conway != null ? 
                          View(await _context.Conway.ToListAsync()) :
                          Problem("Entity set 'conwayContext.Conway'  is null.");
        }

        // GET: Conways/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Conway == null)
            {
                return NotFound();
            }

            var conway = await _context.Conway
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conway == null)
            {
                return NotFound();
            }

            return View(conway);
        }

        // GET: Conways/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Conways/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price")] Conway conway)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conway);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(conway);
        }

        // GET: Conways/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Conway == null)
            {
                return NotFound();
            }

            var conway = await _context.Conway.FindAsync(id);
            if (conway == null)
            {
                return NotFound();
            }
            return View(conway);
        }

        // POST: Conways/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] Conway conway)
        {
            if (id != conway.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conway);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConwayExists(conway.Id))
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
            return View(conway);
        }

        // GET: Conways/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Conway == null)
            {
                return NotFound();
            }

            var conway = await _context.Conway
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conway == null)
            {
                return NotFound();
            }

            return View(conway);
        }

        // POST: Conways/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Conway == null)
            {
                return Problem("Entity set 'conwayContext.Conway'  is null.");
            }
            var conway = await _context.Conway.FindAsync(id);
            if (conway != null)
            {
                _context.Conway.Remove(conway);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConwayExists(int id)
        {
          return (_context.Conway?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
