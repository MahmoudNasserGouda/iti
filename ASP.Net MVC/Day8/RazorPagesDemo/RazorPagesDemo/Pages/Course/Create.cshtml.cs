using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesDemo.Pages.Course
{
    public class CreateModel : PageModel
    {
        private Models.ITIContext _context;
        public CreateModel(Models.ITIContext context)
        {
            _context = context;
        }
        
        [BindProperty]
        public Models.Course Course { get; set; }
        public void OnGet()
        {
            Course = new Models.Course();
            ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsName");
            ViewData["TopId"] = new SelectList(_context.Topics, "TopId", "TopName");
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(Course);
                _context.SaveChanges();
                return RedirectToPage("Index");
            }

            ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsName");
            ViewData["TopId"] = new SelectList(_context.Topics, "TopId", "TopName");
            return Page();
        }
    }
}
