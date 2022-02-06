using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pin_Projekt_N.Data;
using Pin_Projekt_N.Models;

namespace Pin_Projekt_N.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ArtiklsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtiklsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Artikls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Artikl.ToListAsync());
        }


        // GET: Artikls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artikl = await _context.Artikl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artikl == null)
            {
                return NotFound();
            }

            return View(artikl);
        }

        // GET: Artikls/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: Artikls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,naziv,cijena,kolicina,opis")] Artikl artikl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artikl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artikl);
        }

        // GET: Artikls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artikl = await _context.Artikl.FindAsync(id);
            if (artikl == null)
            {
                return NotFound();
            }
            return View(artikl);
        }

        // POST: Artikls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,naziv,cijena,kolicina,opis")] Artikl artikl)
        {
            if (id != artikl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artikl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtiklExists(artikl.Id))
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
            return View(artikl);
        }

        // GET: Artikls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artikl = await _context.Artikl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artikl == null)
            {
                return NotFound();
            }

            return View(artikl);
        }

        // POST: Artikls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artikl = await _context.Artikl.FindAsync(id);
            _context.Artikl.Remove(artikl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtiklExists(int id)
        {
            return _context.Artikl.Any(e => e.Id == id);
        }
    }
}
