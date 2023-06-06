using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages.Course
{
    public class IndexModel : PageModel
    {
        //request service from IoC Container
        private ITIContext _context;
        public IndexModel(ITIContext context)
        {
            _context = context;
        }

        public List<Models.Course> Courses { get; set; }

        public IActionResult OnGet()
        {
            Courses = _context.Courses.ToList();
            return Page();
        }

        public IActionResult OnPostDelete(int Id)
        {
            var tobedeleted = _context.Courses.Find(Id);
            _context.Courses.Remove(tobedeleted);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
