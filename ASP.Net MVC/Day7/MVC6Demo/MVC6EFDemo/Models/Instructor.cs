using System;
using System.Collections.Generic;

#nullable disable

namespace MVC6EFDemo.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Courses = new HashSet<Course>();
            Departments = new HashSet<Department>();
        }

        public int InsId { get; set; }
        public string InsName { get; set; }
        public string InsDegree { get; set; }
        public int? DeptId { get; set; }
        public int? Salary { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
