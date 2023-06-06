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
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;

        public IndexModel(ApplicationContext context)
        {
            _context = context;
        }

        public IList<CourseVM> Courses { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Courses = new List<CourseVM>();
            if (_context.Courses != null)
            {
                foreach (var course in _context.Courses.Join(
                    _context.Instructors,
                    c => c.InstructorID,
                    i => i.ID,
                    (c, i) => new 
                    {
                        ID = c.ID,
                        Name = c.Name,
                        Instructor = i.Name 
                    }))
                {
                    CourseVM courseVM = new CourseVM()
                    {
                        ID = course.ID,
                        Name = course.Name,
                        Instructor = course.Instructor
                    };
                    Courses.Add(courseVM);
                }
                //Courses = (IList<CourseVM>)(from course in _context.Courses
                //           join instructor in _context.Instructors on course.InstructorID equals instructor.ID
                //           select new { ID = course.ID, Name = course.Name, Instructor = course.Instructor.Name }).ToListAsync();
            }
        }

        public IActionResult OnPostDelete(int Id)
        {
            var tobedeleted = _context.Courses.Find(Id);
            _context.Courses.Remove(tobedeleted);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }

        public class CourseVM
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public string Instructor { get; set; }
        }
    }
}
