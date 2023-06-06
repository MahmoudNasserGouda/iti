using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationContext _context;

        public DetailsModel(ApplicationContext context)
        {
            _context = context;
        }

        public CourseVM Course { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.Join(
                    _context.Instructors,
                    c => c.InstructorID,
                    i => i.ID,
                    (c, i) => new
                    {
                        ID = c.ID,
                        Name = c.Name,
                        Instructor = i.Name
                    }).FirstOrDefaultAsync(m => m.ID == id);
            if (course == null)
            {
                return NotFound();
            }
            else
            {
                Course = new CourseVM();
                Course.ID = course.ID;
                Course.Name = course.Name;
                Course.Instructor = course.Instructor;
            }
            return Page();
        }

        public class CourseVM
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public string Instructor { get; set; }
        }
    }
}
