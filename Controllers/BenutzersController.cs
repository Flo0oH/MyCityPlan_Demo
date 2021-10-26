using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCityPlan_Demo.Data;
using MyCityPlan_Demo.Models;

namespace MyCityPlan_Demo.Controllers
{
    public class BenutzersController : Controller
    {
        private readonly ApplicationDbContext _context;

        //Dep. Injection
        // 
        //public  IActionResult Index()
        //{
        //    var benutzer = _context.Benutzer.ToList();
        //    ViewBag.Benutzer = benutzer;
        //    return View();

        //}
        public BenutzersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Benutzers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Benutzer.ToListAsync());
        }

        // GET: Benutzers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var benutzer = await _context.Benutzer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (benutzer == null)
            {
                return NotFound();
            }

            return View(benutzer);
        }

        // GET: Benutzers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Benutzers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Property_1")] Benutzer benutzer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(benutzer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(benutzer);
        }

        // GET: Benutzers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var benutzer = await _context.Benutzer.FindAsync(id);
            if (benutzer == null)
            {
                return NotFound();
            }
            return View(benutzer);
        }

        // POST: Benutzers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Property_1")] Benutzer benutzer)
        {
            if (id != benutzer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(benutzer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BenutzerExists(benutzer.Id))
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
            return View(benutzer);
        }

        // GET: Benutzers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var benutzer = await _context.Benutzer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (benutzer == null)
            {
                return NotFound();
            }

            return View(benutzer);
        }

        // POST: Benutzers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var benutzer = await _context.Benutzer.FindAsync(id);
            _context.Benutzer.Remove(benutzer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BenutzerExists(int id)
        {
            return _context.Benutzer.Any(e => e.Id == id);
        }
    }
}
