using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC6EFDemo.Models;

namespace MVC6EFDemo.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ITIContext _context;

        //ctor injection
        public CoursesController(ITIContext context)
        {
            _context = context;
        }

        // GET: Courses
        //[ActionName("All")]
        [Route("/CoursesData")]
        public async Task<IActionResult> Index()
        {
            var iTIContext = _context.Courses.Include(c => c.Ins).Include(c => c.Top);
            return View("Index",await iTIContext.ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Ins)
                .Include(c => c.Top)
                .FirstOrDefaultAsync(m => m.CrsId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsId");
            ViewData["TopId"] = new SelectList(_context.Topics, "TopId", "TopId");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CrsId,CrsName,CrsDuration,InsId,TopId")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsId", course.InsId);
            ViewData["TopId"] = new SelectList(_context.Topics, "TopId", "TopId", course.TopId);
            return View(course);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsId", course.InsId);
            ViewData["TopId"] = new SelectList(_context.Topics, "TopId", "TopId", course.TopId);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CrsId,CrsName,CrsDuration,InsId,TopId")] Course course)
        {
            if (id != course.CrsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.CrsId))
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
            ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsId", course.InsId);
            ViewData["TopId"] = new SelectList(_context.Topics, "TopId", "TopId", course.TopId);
            return View(course);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Ins)
                .Include(c => c.Top)
                .FirstOrDefaultAsync(m => m.CrsId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.CrsId == id);
        }
    }
}
