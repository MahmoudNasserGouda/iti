using System;
using System.Collections.Generic;

#nullable disable

namespace MVC6EFDemo.Models
{
    public partial class Department
    {
        public Department()
        {
            Student1s = new HashSet<Student1>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptDesc { get; set; }
        public string DeptLocation { get; set; }
        public int? DeptManager { get; set; }
        public DateTime? Hiredate { get; set; }

        public virtual Instructor DeptManagerNavigation { get; set; }
        public virtual ICollection<Student1> Student1s { get; set; }
    }
}
