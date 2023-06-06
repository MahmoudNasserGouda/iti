using System;
using System.Collections.Generic;

#nullable disable

namespace RazorPagesDemo.Models
{
    public partial class Student1
    {
        public Student1()
        {
            InverseStSuperNavigation = new HashSet<Student1>();
            StudCourses = new HashSet<StudCourse>();
        }

        public int StId { get; set; }
        public string StFname { get; set; }
        public string StLname { get; set; }
        public string StAddress { get; set; }
        public int? StAge { get; set; }
        public int? DeptId { get; set; }
        public int? StSuper { get; set; }

        public virtual Department Dept { get; set; }
        public virtual Student1 StSuperNavigation { get; set; }
        public virtual ICollection<Student1> InverseStSuperNavigation { get; set; }
        public virtual ICollection<StudCourse> StudCourses { get; set; }
    }
}
