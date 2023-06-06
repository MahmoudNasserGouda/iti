using System;
using System.Collections.Generic;

#nullable disable

namespace RazorPagesDemo.Models
{
    public partial class Course
    {
        public Course()
        {
            StudCourses = new HashSet<StudCourse>();
        }

        public int CrsId { get; set; }
        public string CrsName { get; set; }
        public int? CrsDuration { get; set; }
        public int? InsId { get; set; }
        public int? TopId { get; set; }

        public virtual Instructor Ins { get; set; }
        public virtual Topic Top { get; set; }
        public virtual ICollection<StudCourse> StudCourses { get; set; }
    }
}
