using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webproje2021.Data;
using webproje2021.Models;

namespace webproje2021.Controllers
{
    public class urunlerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public urunlerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: urunler
        public async Task<IActionResult> Index()
        {
            return View(await _context.urunler.ToListAsync());
        }

        // GET: urunler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urunler = await _context.urunler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urunler == null)
            {
                return NotFound();
            }

            return View(urunler);
        }

        // GET: urunler/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: urunler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,urunadi,kalorisi,fiyati")] urunler urunler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(urunler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(urunler);
        }

        // GET: urunler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urunler = await _context.urunler.FindAsync(id);
            if (urunler == null)
            {
                return NotFound();
            }
            return View(urunler);
        }

        // POST: urunler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,urunadi,kalorisi,fiyati")] urunler urunler)
        {
            if (id != urunler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(urunler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!urunlerExists(urunler.Id))
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
            return View(urunler);
        }

        // GET: urunler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urunler = await _context.urunler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urunler == null)
            {
                return NotFound();
            }

            return View(urunler);
        }

        // POST: urunler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var urunler = await _context.urunler.FindAsync(id);
            _context.urunler.Remove(urunler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool urunlerExists(int id)
        {
            return _context.urunler.Any(e => e.Id == id);
        }
    }
}
