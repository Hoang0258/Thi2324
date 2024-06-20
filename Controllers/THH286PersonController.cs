using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using THHBT2324.Models;

namespace THHBT2324.Controllers
{
    public class THH286PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public THH286PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: THH286Person
        public async Task<IActionResult> Index()
        {
            return View(await _context.THH286Person.ToListAsync());
        }

        // GET: THH286Person/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tHH286Person = await _context.THH286Person
                .FirstOrDefaultAsync(m => m.THH286ID == id);
            if (tHH286Person == null)
            {
                return NotFound();
            }

            return View(tHH286Person);
        }

        // GET: THH286Person/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: THH286Person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("THH286ID,THH286Name,THH286DiaChi")] THH286Person tHH286Person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tHH286Person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tHH286Person);
        }

        // GET: THH286Person/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tHH286Person = await _context.THH286Person.FindAsync(id);
            if (tHH286Person == null)
            {
                return NotFound();
            }
            return View(tHH286Person);
        }

        // POST: THH286Person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("THH286ID,THH286Name,THH286DiaChi")] THH286Person tHH286Person)
        {
            if (id != tHH286Person.THH286ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tHH286Person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!THH286PersonExists(tHH286Person.THH286ID))
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
            return View(tHH286Person);
        }

        // GET: THH286Person/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tHH286Person = await _context.THH286Person
                .FirstOrDefaultAsync(m => m.THH286ID == id);
            if (tHH286Person == null)
            {
                return NotFound();
            }

            return View(tHH286Person);
        }

        // POST: THH286Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tHH286Person = await _context.THH286Person.FindAsync(id);
            if (tHH286Person != null)
            {
                _context.THH286Person.Remove(tHH286Person);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool THH286PersonExists(string id)
        {
            return _context.THH286Person.Any(e => e.THH286ID == id);
        }
    }
}
