using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace RazorPagesDemo.Pages.Course
{
    public class EditModel : PageModel
    {

        private Models.ITIContext _context;
        public EditModel(Models.ITIContext context)
        {
            _context = context;
        }

        [TempData]
        public string CourseName { get; set; }

        [BindProperty]
        public Models.Course Course { get; set; }
        public IActionResult OnGet(int? id)
        {
            if(id != null)
            {
                Course = _context.Courses.Find(id);
                ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsName", Course.InsId);
                ViewData["TopId"] = new SelectList(_context.Topics, "TopId", "TopName", Course.TopId);
                return Page();
            }
            return RedirectToPage("Index");
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Entry(Course).State = EntityState.Modified;
                _context.SaveChanges();

                CourseName = Course.CrsName;
                HttpContext.Session.SetString("CourseName", Course.CrsName);
                //TempData["CourseName"] = Course.CrsName;
                return RedirectToPage("Index");
            }

            ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsName", Course.InsId);
            ViewData["TopId"] = new SelectList(_context.Topics, "TopId", "TopName", Course.TopId);
            return Page();
        }
    }
}
